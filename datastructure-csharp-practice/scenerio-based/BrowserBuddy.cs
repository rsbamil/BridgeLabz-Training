using System;
using System.Collections.Generic;

namespace BrowserBuddy
{
    // Doubly Linked List Node
    class HistoryNode
    {
        public string Url;
        public HistoryNode Prev;
        public HistoryNode Next;

        public HistoryNode(string url)
        {
            Url = url;
        }
    }

    // Browser Tab
    class BrowserTab
    {
        private HistoryNode head;
        private HistoryNode current;

        public BrowserTab(string homepage)
        {
            head = new HistoryNode(homepage);
            current = head;
        }

        public void Visit(string url)
        {
            HistoryNode newNode = new HistoryNode(url);
            current.Next = newNode;
            newNode.Prev = current;
            current = newNode;

            Console.WriteLine("Visited: " + url);
        }

        public void Back()
        {
            if (current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("Back to: " + current.Url);
            }
            else
            {
                Console.WriteLine("No previous page.");
            }
        }

        public void Forward()
        {
            if (current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Forward to: " + current.Url);
            }
            else
            {
                Console.WriteLine("No next page.");
            }
        }

        public string CurrentPage()
        {
            return current.Url;
        }
    }

    // Browser Manager with Stack
    class BrowserManager
    {
        private BrowserTab activeTab;
        private Stack<BrowserTab> closedTabs = new Stack<BrowserTab>();

        public BrowserManager(string homepage)
        {
            activeTab = new BrowserTab(homepage);
        }

        public void Visit(string url)
        {
            activeTab.Visit(url);
        }

        public void Back()
        {
            activeTab.Back();
        }

        public void Forward()
        {
            activeTab.Forward();
        }

        public void CloseTab()
        {
            closedTabs.Push(activeTab);
            Console.WriteLine("Tab closed.");
            activeTab = new BrowserTab("about:blank");
        }

        public void RestoreTab()
        {
            if (closedTabs.Count > 0)
            {
                activeTab = closedTabs.Pop();
                Console.WriteLine("Tab restored.");
                Console.WriteLine("Current Page: " + activeTab.CurrentPage());
            }
            else
            {
                Console.WriteLine("No closed tabs available.");
            }
        }

        public void ShowCurrentPage()
        {
            Console.WriteLine("Current Page: " + activeTab.CurrentPage());
        }
    }

    class BrowserBuddy
    {
        static void Main()
        {
            BrowserBuddy obj = new BrowserBuddy();
            obj.Menu();
        }
        void Menu()
        {
            Console.Write("Enter homepage URL: ");
            string homepage = Console.ReadLine();
            BrowserManager browser = new BrowserManager(homepage);
            int choice;

            do
            {
                Console.WriteLine("\n===== BrowserBuddy Menu =====");
                Console.WriteLine("1. Visit New Page");
                Console.WriteLine("2. Back");
                Console.WriteLine("3. Forward");
                Console.WriteLine("4. Close Current Tab");
                Console.WriteLine("5. Restore Closed Tab");
                Console.WriteLine("6. Show Current Page");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter URL: ");
                        string url = Console.ReadLine();
                        browser.Visit(url);
                        break;

                    case 2:
                        browser.Back();
                        break;

                    case 3:
                        browser.Forward();
                        break;

                    case 4:
                        browser.CloseTab();
                        break;

                    case 5:
                        browser.RestoreTab();
                        break;

                    case 6:
                        browser.ShowCurrentPage();
                        break;

                    case 0:
                        Console.WriteLine("Exiting BrowserBuddy...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            while (choice != 0);
        }
    }

}
