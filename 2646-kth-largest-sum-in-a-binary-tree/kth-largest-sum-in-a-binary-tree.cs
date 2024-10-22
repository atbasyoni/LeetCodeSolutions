/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public long KthLargestLevelSum(TreeNode root, int k) {
        List<long> levelSums = new List<long>();
        
        Queue<TreeNode> levelQueue = new Queue<TreeNode>();
        levelQueue.Enqueue(root);

        while (levelQueue.Count > 0) {
            int levelSize = levelQueue.Count;
            long currentLevelSum = 0;

            for (int i = 0; i < levelSize; i++) {
                TreeNode currentNode = levelQueue.Dequeue();
                currentLevelSum += currentNode.val;

                if (currentNode.left != null) {
                    levelQueue.Enqueue(currentNode.left);
                }
                if (currentNode.right != null) {
                    levelQueue.Enqueue(currentNode.right);
                }
            }

            levelSums.Add(currentLevelSum);
        }

        levelSums.Sort((a, b) => b.CompareTo(a));

        if (k > levelSums.Count) {
            return -1;
        }

         return levelSums[k - 1];
    }
}