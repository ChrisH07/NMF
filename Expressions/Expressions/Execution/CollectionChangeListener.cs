﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NMF.Expressions
{
    public class CollectionChangeListener<T> : IChangeListener
    {
        private INotifyCollectionChanged collection;
        private bool engineNotified;

        private bool isReset;
        private List<T> addedItems;
        private List<T> removedItems;
        private List<T> movedItems;

        public INotifiable Node { get; private set; }

        public CollectionChangeListener(INotifiable node)
        {
            Node = node;
        }

        public void Subscribe(INotifyCollectionChanged collection)
        {
            if (this.collection != collection)
            {
                Unsubscribe();
                this.collection = collection;
                collection.CollectionChanged += OnCollectionChanged;
            }
        }

        public void Unsubscribe()
        {
            if (collection != null)
            {
                collection.CollectionChanged -= OnCollectionChanged;
                collection = null;
            }
            engineNotified = false;
        }

        public INotificationResult AggregateChanges()
        {
            INotificationResult result;
            if (!HasChanges())
                result = UnchangedNotificationResult.Instance;
            else if (isReset)
                result = new CollectionChangedNotificationResult<T>(null);
            else
                result = new CollectionChangedNotificationResult<T>
                (
                    null,
                    addedItems,
                    removedItems,
                    movedItems
                );
            
            engineNotified = false;
            isReset = false;
            addedItems = null;
            removedItems = null;
            movedItems = null;

            return result;
        }

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    TrackAddAction(e.NewItems);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    TrackRemoveAction(e.OldItems);
                    break;
                case NotifyCollectionChangedAction.Move:
                    TrackMoveAction(e.OldItems);
                    break;
                case NotifyCollectionChangedAction.Replace:
                    TrackReplaceAction(e.OldItems, e.NewItems);
                    break;
                case NotifyCollectionChangedAction.Reset:
                    TrackResetAction();
                    break;
            }

            if (!engineNotified)
            {
                engineNotified = true;
                ExecutionEngine.Current.InvalidateNode(this);
            }
        }

        private void TrackAddAction(IList addedItems)
        {
            if (isReset)
                return;
            foreach (T item in addedItems)
            {
                if (removedItems == null || !removedItems.Remove(item))
                {
                    if (this.addedItems == null)
                        this.addedItems = new List<T>();
                    this.addedItems.Add(item);
                }
            }
        }

        private void TrackRemoveAction(IList removedItems)
        {
            if (isReset)
                return;
            foreach (T item in removedItems)
            {
                if (addedItems == null || !addedItems.Remove(item))
                {
                    if (this.removedItems == null)
                        this.removedItems = new List<T>();
                    this.removedItems.Add(item);
                }
            }
        }

        private void TrackMoveAction(IList movedItems)
        {
            if (isReset)
                return;
            if (this.movedItems == null)
                this.movedItems = new List<T>();
            foreach (T item in movedItems)
                this.movedItems.Add(item);
        }

        private void TrackReplaceAction(IList replacedItems, IList replacingItems)
        {
            if (isReset)
                return;
            foreach (T item in replacingItems)
            {
                if (removedItems == null || !removedItems.Remove(item))
                {
                    if (addedItems == null)
                        addedItems = new List<T>();
                    addedItems.Add(item);
                }
            }

            foreach (T item in replacedItems)
            {
                if (addedItems == null || !addedItems.Remove(item))
                {
                    if (removedItems == null)
                        removedItems = new List<T>();
                    removedItems.Add(item);
                }
            }
        }

        private void TrackResetAction()
        {
            isReset = true;
        }

        private bool HasChanges()
        {
            return
                isReset ||
                addedItems?.Count > 0 ||
                removedItems?.Count > 0 ||
                movedItems?.Count > 0;
        }
    }
}
