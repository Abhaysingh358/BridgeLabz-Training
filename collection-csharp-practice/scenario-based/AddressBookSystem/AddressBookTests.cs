using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BridgeLabz.collection_csharp_practice.scenario_based.AddressBookSystem;

    namespace AddressBookSystem.MSTests
    {
        [TestClass]
        public class AddressBookTests
        {
            [TestMethod]
            public void AddContact_ValidContact_ReturnsTrue()
            {
                IAddressBookLogic book = new AddressBook();

                Contact contact = new Contact();
                contact.SetFirstName("Amit");

                bool result = book.AddContactForTest(contact);

                Assert.IsTrue(result);
            }

            [TestMethod]
            public void AddContact_DuplicateContact_ReturnsFalse()
            {
                IAddressBookLogic book = new AddressBook();

                Contact c1 = new Contact();
                c1.SetFirstName("Amit");
                book.AddContactForTest(c1);

                Contact c2 = new Contact();
                c2.SetFirstName("Amit");

                bool result = book.AddContactForTest(c2);

                Assert.IsFalse(result);
            }

            [TestMethod]
            public void DeleteContact_ExistingContact_ReturnsTrue()
            {
                IAddressBookLogic book = new AddressBook();

                Contact contact = new Contact();
                contact.SetFirstName("Rahul");
                book.AddContactForTest(contact);

                bool result = book.DeleteContactForTest("Rahul");

                Assert.IsTrue(result);
            }

            [TestMethod]
            public void DeleteContact_NonExistingContact_ReturnsFalse()
            {
                IAddressBookLogic book = new AddressBook();

                bool result = book.DeleteContactForTest("Unknown");

                Assert.IsFalse(result);
            }

        [TestMethod]
        public void AddContact_InvalidName_ThrowsException()
        {
            // Arrange
            IAddressBookLogic book = new AddressBook();
            Contact contact = new Contact();
            contact.SetFirstName("123");

            // Act & Assert
            Assert.Throws<InvalidInputException>(() =>
            {
                book.AddContactForTest(contact);
            });
        }
    }
    }


