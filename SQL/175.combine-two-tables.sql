--
-- @lc app=leetcode id=175 lang=mysql
--
-- [175] Combine Two Tables
--

-- @lc code=start
# Write your MySQL query statement below
SELECT p.firstName, p.lastName, a.city, a.state FROM Person as p
LEFT JOIN Address AS a ON p.personID = a.personID
  

-- @lc code=end

