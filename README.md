Console App to check whether path2 is a subdirectories of path1


Write a function in C# or Java to meet the following specifications: 

the function accepts two strings as arguments and returns true/false 
the two strings represent paths to directories in a Linux (i.e. POSIX-style) filesystem, where directory elements are delimited by a forward slash. e.g. "a/b" is a subdirectory of "/a". 
subdirectories of subdirectories are also referred to as subdirectories, with any level of nesting. So by this definition, "/a/b/c/d" is also a subdirectory of "/a". 
call the two strings s1 and s2. If s2 is a subdirectory of s1, or the same directory as s1, the function should return true, otherwise it should return false 

Notes: 

the strings may or may not end in a trailing slash. The presence or absence of the trailing slash does not change the meaning of the string in any way 
the paths may or may not actually exist on the system running the function - this should have no effect on the logic 

Examples: 

If the function is named "f", then: 
f("/a", "/a/b") == true
f("/a", "/b") == false
f("/ab", "/cd") == false
f("/", "/very/very/deep/path/") == true
