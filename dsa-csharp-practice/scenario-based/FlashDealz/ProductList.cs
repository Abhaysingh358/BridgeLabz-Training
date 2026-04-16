using System;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.FlashDealz
{
    internal class ProductList
    {
        private ProductNode Head;
        private ProductNode Tail;
        private int Count;

        public ProductList()
        {
            this.Head = null;
            this.Tail = null;
            this.Count = 0;
        }

        public ProductNode GetHead()
        {
            return Head;
        }

        public int GetCount()
        {
            return Count;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void AddProduct(Product product)
        {
            ProductNode productnode = new ProductNode(product);

            if (Head == null)
            {
                Head = productnode;
                Tail = productnode;
                Count++;
                return;
            }

            Tail.SetNext(productnode);
            Tail = productnode;
            Count++;
        }

        // to  change th products
        public bool UpdateDiscountByName(string productName, double newDiscount)
        {
            if (Head == null)
                return false;

            ProductNode temp = Head;

            while (temp != null)
            {
                if (temp.GetProduct().GetProductName()
                    .Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    temp.GetProduct().SetDiscount(newDiscount);

                    //  Auto sort after updating discount
                    QuickSortByDiscount();

                    return true;
                }

                temp = temp.GetNext();
            }

            return false;
        }

        // to display the produts
        public void DisplayProducts()
        {
            if (Head == null)
            {
                Console.WriteLine("Product list is Empty");
                return;
            }

            ProductNode temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.GetProduct().ToString());
                Console.WriteLine("\n");
                temp = temp.GetNext();
            }
        }

        public void DisplayTopProducts(int products)
        {
            if (Head == null)
            {
                Console.WriteLine("Product list is Empty");
                return;
            }

            ProductNode temp = Head;
            int count = 0;

            while (temp != null && count < products)
            {
                Console.WriteLine(temp.GetProduct());
                Console.WriteLine("---------------------------------\n");

                temp = temp.GetNext();
                count++;
            }
        }

        public void QuickSortByDiscount()
        {
            if (Head == null || Head.GetNext() == null)
                return;

            ProductNode end = Tail; // tail exists, so we use it directly
            QuickSort(Head, end);

            Tail = GetTail(Head);
        }

        // ---------------- QUICK SORT RECURSION ----------------
        private void QuickSort(ProductNode start, ProductNode end)
        {
            if (start == null || end == null || start == end)
                return;

            ProductNode pivotPrev = Partition(start, end);

            if (pivotPrev != null && start != pivotPrev)
            {
                QuickSort(start, pivotPrev);
            }

            if (pivotPrev != null && pivotPrev.GetNext() != null)
            {
                QuickSort(pivotPrev.GetNext(), end);
            }
        }

        private ProductNode Partition(ProductNode start, ProductNode end)
        {
            double pivotDiscount = end.GetProduct().GetDiscount();

            ProductNode pivotPrev = start;
            ProductNode curr = start;
            ProductNode temp = start;

            while (temp != end)
            {
                if (temp.GetProduct().GetDiscount() >= pivotDiscount)
                {
                    Swap(curr, temp);
                    pivotPrev = curr;
                    curr = curr.GetNext();
                }

                temp = temp.GetNext();
            }

            Swap(curr, end);
            return pivotPrev;
        }

        // ---------------- SWAP PRODUCT DATA ----------------
        private void Swap(ProductNode a, ProductNode b)
        {
            Product temp = a.GetProduct();
            a.SetProduct(b.GetProduct());
            b.SetProduct(temp);
        }

        // ---------------- GET TAIL ----------------
        private ProductNode GetTail(ProductNode node)
        {
            while (node != null && node.GetNext() != null)
            {
                node = node.GetNext();
            }
            return node;
        }
    }
}
