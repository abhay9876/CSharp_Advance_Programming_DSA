/*2.Role-Based Access Control (RBAC)
Use Case: Assign and verify user roles and permissions.
OOP Concepts:
● Interface: Role
● Encapsulation: Role mappings hidden inside auth system.
● Abstraction & Polymorphism: Different roles implement different behavior.*/



using System;

public interface Role
{
    bool Permission(string permission);
}

public class Admin : Role
{
    public bool Permission(string permission)
    {
        return true; 
    }
}

public class User : Role
{
    public bool Permission(string permission)
    {
        return permission=="Read";
    }
}


public class AuthSystem
{
    private Dictionary<string, Role> roleMap = new Dictionary<string, Role>();

    public void AssignRole(string name, Role role)
    {
        roleMap[name] = role;
    }

    public bool CheckAccess(string name, string permission)
    {
        if (roleMap.ContainsKey(name))
        {
            return roleMap[name].Permission(permission);
        }
        return false;
    }
}



