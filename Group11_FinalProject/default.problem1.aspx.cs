using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group11_FinalProject
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // open web form for this leet code problem
        }

        protected void cmdProblem1_Click(object sender, EventArgs e)
        {

        }

        protected void cmdProblem2_Click(object sender, EventArgs e)
        {

        }

        protected void cmdProblem3_Click(object sender, EventArgs e)
        {
            public int GetMoneyAmount(int n)
            {
                // Creating a 2D array to store the minimum cost to guarantee a win for range [i, j]
                int[,] dp = new int[n + 1, n + 1];

                // Loop for different range sizes
                for (int len = 2; len <= n; len++)
                {
                    // Loop for different starting points of the range
                    for (int start = 1; start <= n - len + 1; start++)
                    {
                        int minCost = int.MaxValue;
                        // Loop for different guesses within the current range
                        for (int guess = start; guess < start + len - 1; guess++)
                        {
                            // Calculate the cost for this guess and add it to the cost of subproblems
                            int cost = guess + Math.Max(dp[start, guess - 1], dp[guess + 1, start + len - 1]);
                            // Update the minimum cost if needed
                            minCost = Math.Min(minCost, cost);
                        }
                        // Save the minimum cost for the current range
                        dp[start, start + len - 1] = minCost;
                    }
                }

                // The result is the minimum cost to guarantee a win for the entire range [1, n]
                return dp[1, n];
            }
    }
}