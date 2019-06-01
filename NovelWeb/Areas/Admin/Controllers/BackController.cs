﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace NovelSite.Areas.Admin.Controllers
{
    public class BackController : NovelWeb.Areas.Admin.Controllers.BaseController
    {
        // 注入EF上下文
        private readonly NovelWebContext _dbCotext;
        public BackController(NovelWebContext dbContext)
        {
            _dbCotext = dbContext;
        }

        public IActionResult Index()
        {
            int n = 10;
            long s = fun(n);

            return Content(n + "!阶乘（递归）：" + s + " ------- " + n + "!阶乘（for循环）： " + FactorialRecursion(n) + " ------- " + RecUrsive(5));
        }

        #region 阶乘

        /// <summary>
        /// 先把fun(n-1)算完，然后再逐个回去相乘，顺序是1*2*3*4......
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public long fun(int n)
        {
            if (n < 1)
                return 0;
            if (n == 1)
                return 1;

            return n * fun(n - 1);
        }

        public int FactorialRecursion(int number)
        {
            int F = 1;
            for (int i = 1; i <= number; i++)
            {
                F *= i;
            }
            return F;
        }

        #endregion

        #region 斐波那契数列

        public int Fib(int n)
        {
            if (n <= 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fib(n - 1) + Fib(n - 2);
        }

        public int RecUrsive(int index)

        {

            if (index < 3)//若index的值等于1或2，则返回1

            {

                return 1;

            }

            else

            {

                return RecUrsive(index - 1) + RecUrsive(index - 2);

            }

        }

        #endregion

    }
}