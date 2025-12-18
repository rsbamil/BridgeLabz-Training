class Solution {
    public boolean isValid(String s) {
        Stack<Character> st = new Stack<>();
        for (char c : s.toCharArray()) {
            if (c == '(' || c == '{' || c == '[') {
                st.push(c);
            } else {
                if (st.isEmpty()) {
                    return false;
                }
                char rem = st.pop();
                if ((c == ')' && rem != '(' || c == '}' && rem != '{' || c == ']' && rem != '[')) {
                    return false;
                }
            }
        }
        return st.isEmpty();
    }
}