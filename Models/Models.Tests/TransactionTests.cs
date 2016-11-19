﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMF.Models.Repository;
using NMF.Models.Tests.Railway;

namespace NMF.Models.Tests
{
    [TestClass]
    public class TransactionTests
    {
        private const string BaseUri = "http://github.com/NMFCode/NMF/Models/Models.Test/railway.railway";

        [TestMethod]
        public void RollbackTest()
        {
            var model = LoadRailwayModel(new ModelRepository());
            var referenceModel = LoadRailwayModel(new ModelRepository());

            using (var trans = new NMFTransaction(model))
            {
                var route = new Route() { Id = 42 };
                model.Routes.Add(route);
                model.Semaphores[0].Signal = Signal.FAILURE;
                var debug = model.Routes[0].DefinedBy[0];
                model.Routes[0].DefinedBy.RemoveAt(0);
                //model.Routes[0].DefinedBy[0].Elements.RemoveAt(0);

            }

            Assert.AreEqual(model.Routes.Count, referenceModel.Routes.Count);
            Assert.AreEqual(model.Routes[0].DefinedBy.Count, referenceModel.Routes[0].DefinedBy.Count);
            Assert.AreEqual(model.Routes[0].DefinedBy[0].Elements.Count, referenceModel.Routes[0].DefinedBy[0].Elements.Count);
            Assert.AreEqual(model.Semaphores[0].Signal, referenceModel.Semaphores[0].Signal);
            //Assert.AreEqual(model, referenceModel);



            /*//Load second instance of the model
            var newRepository = new ModelRepository();
            var newModel = LoadRailwayModel(newRepository);

            //Apply changes to the new model
            newChanges.Apply(newRepository);

            Assert.AreEqual(model.Routes.Count, newModel.Routes.Count);
            Assert.AreEqual(model.Routes[0].DefinedBy.Count, newModel.Routes[0].DefinedBy.Count);
            Assert.AreEqual(model.Routes[0].DefinedBy[0].Elements.Count, newModel.Routes[0].DefinedBy[0].Elements.Count);
            Assert.AreEqual(model.Semaphores[0].Signal, newModel.Semaphores[0].Signal);*/
        }

        [TestMethod]
        public void CommitTest()
        {
            Assert.Fail();
        }

        

        private RailwayContainer LoadRailwayModel(ModelRepository repository)
        {
            var railwayModel = repository.Resolve(new Uri(BaseUri), "railway.railway").Model;
            Assert.IsNotNull(railwayModel);
            var railway = railwayModel.RootElements.Single() as RailwayContainer;
            Assert.IsNotNull(railway);
            return railway;
        }
    }
}
