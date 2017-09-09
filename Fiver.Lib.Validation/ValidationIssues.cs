using System;
using System.Collections.Generic;

namespace Fiver.Lib.Validation
{
    public sealed class ValidationIssues
    {
        private readonly List<ValidationIssue> issues;

        public ValidationIssues()
        {
            this.issues = new List<ValidationIssue>();
        }

        public IReadOnlyList<ValidationIssue> Issues => this.issues;
        public bool HasIssues => this.issues.Count > 0;

        public ValidationIssues AddRule(IRule rule)
        {
            if (!rule.IsValid())
                this.issues.Add(new ValidationIssue(rule.Field, rule.Message));

            return this;
        }

        public ValidationIssues AddIf(
            string field, bool condition, string message)
        {
            if (condition)
                this.issues.Add(new ValidationIssue(field, message));

            return this;
        }

        public ValidationIssues AddIf(
            string field, Func<bool> predicate, string message)
        {
            if (predicate())
                this.issues.Add(new ValidationIssue(field, message));

            return this;
        }
    }
}
