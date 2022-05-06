#include "easy_ValidParentheses.h"


int ValidateParentheses(std::string s) {
    std::stack<char> bracket;
    for (char& c : s) {
        switch (c) {
        case '(': 
            bracket.push(c); break;
        case '{': 
            bracket.push(c); break;
        case '[': 
            bracket.push(c); break;
        case ')': 
            if (bracket.empty() || bracket.top() != '(') return false; 
            else bracket.pop(); 
            break;
        case '}': 
            if (bracket.empty() || bracket.top() != '{') return false; 
            else bracket.pop(); 
            break;
        case ']': 
            if (bracket.empty() || bracket.top() != '[') return false; 
            else bracket.pop(); 
            break;
        default:;
        }
    }
    return bracket.empty();
}