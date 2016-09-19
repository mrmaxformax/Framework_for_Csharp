﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPAutomation
{

    public class LeftNavigation
    {
        
        public class Posts
        {
            public class AddNew
            {
                public static void Select()
                {
                    MenuSelector.Select("menu-posts", "Add New");
                }
            }

            public class AllPosts
            {
                public static void Select()
                {
                    MenuSelector.Select("menu-posts", "All Posts");
                }
            }

        }

        public class Pages
        {
            public class AllPages
            {
                public static void Select()
                {
                    MenuSelector.Select("menu-pages", "All Pages");
                }
            }
        }


    }

    
}
