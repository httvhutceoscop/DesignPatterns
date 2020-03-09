using System;

namespace DesignPatterns.Examples.Template
{
    /// <summary>
    /// The Base Abstract Class defines a template method that contains a skeleton of
    /// some algorithm, composed of calls to (usually) abstract primitive
    /// operations.
    /// 
    /// Concrete subclasses should implement these operations, but leave the
    /// template method itself intact.
    /// </summary>
    public abstract class BaseAbstractClass
    {
        public void TemplateMethod()
        {
            this.BaseOperation1();
            this.RequiredOperations1();
            this.BaseOperation2();
            this.Hook1();
            this.RequiredOperation2();
            this.BaseOperation3();
            this.Hook2();
        }

        // These operations already have implementations.
        protected void BaseOperation1()
        {
            Console.WriteLine("BaseAbstractClass says: I am doing the bulk of the work");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("BaseAbstractClass says: But I let subclasses override some operations");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("BaseAbstractClass says: But I am doing the bulk of the work anyway");
        }

        // These operations have to be implemented in subclasses.
        protected abstract void RequiredOperations1();

        protected abstract void RequiredOperation2();

        // These are "hooks." Subclasses may override them, but it's not
        // mandatory since the hooks already have default (but empty)
        // implementation. Hooks provide additional extension points in some
        // crucial places of the algorithm.
        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }
}