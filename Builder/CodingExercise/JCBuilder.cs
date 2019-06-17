using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Coding.Exercise
{
  class ClassMember
  {
    public string MemberType, MemberName;
    public List<ClassMember> Members = new List<ClassMember>();
    public ClassMember()
    {
    }
    public ClassMember(string memberType, string memberName)
    {
      MemberType = memberType;
      MemberName = memberName;
    }
  }

  class Class
  {
    public string ClassName;
    public List<ClassMember> Members = new List<ClassMember>();
    public Class()
    {
    }
    public Class(string className)
    {
      ClassName = className;
    }
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append($"public class {ClassName}\n");
      sb.Append($"{{\n");

      foreach (var m in Members){
        sb.Append($"  public {m.MemberType} {m.MemberName};\n");
      }

      sb.Append($"}}\n");
      return sb.ToString();
    }
  }

  public class CodeBuilder
  {
    private readonly string className;

    public CodeBuilder(string className)
    {
      this.className = className;
      root.ClassName = className;
    }
    public CodeBuilder AddField(string memberName, string memberType)
    {
      var m = new ClassMember(memberType, memberName);
      root.Members.Add(m);
      return this;
    }
    public override string ToString()
    {
      return root.ToString();
    }
    Class root = new Class();
  }

  public class Demo
  {
    static void Main(string[] args)
    {
      var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "string");
      WriteLine(cb);
    }
  }
}
