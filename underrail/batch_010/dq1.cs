using System;
using System.Collections.Generic;
using Ouroboros.Core.Logging;
using Ouroboros.Events;

// Token: 0x02000169 RID: 361
internal class dq1 : eta
{
	// Token: 0x06000914 RID: 2324 RVA: 0x00025AD8 File Offset: 0x00023CD8
	public bool e()
	{
		return this.c;
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x00025AE0 File Offset: 0x00023CE0
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x00025AEC File Offset: 0x00023CEC
	public dq1()
	{
		this.d = dr3.e();
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x00025B1C File Offset: 0x00023D1C
	public void RegisterHandler<T>(IGlobalEventHandler<T> handler) where T : dli
	{
		this.ao3(typeof(T), handler);
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x00025B34 File Offset: 0x00023D34
	public void ao3(Type A_0, b61 A_1)
	{
		if (!this.e(A_0))
		{
			return;
		}
		if (A_1 == null)
		{
			this.d(A_0);
			return;
		}
		this.i(A_0).Add(A_1);
		this.h(A_0);
		this.b(A_0, A_1);
	}

	// Token: 0x06000919 RID: 2329 RVA: 0x00025B78 File Offset: 0x00023D78
	public void UnregisterHandler<T>(IGlobalEventHandler<T> handler) where T : dli
	{
		this.ao4(typeof(T), handler);
	}

	// Token: 0x0600091A RID: 2330 RVA: 0x00025B8C File Offset: 0x00023D8C
	public void ao4(Type A_0, b61 A_1)
	{
		if (!this.e(A_0))
		{
			return;
		}
		if (A_1 == null)
		{
			this.c(A_0);
			return;
		}
		if (this.i(A_0).Remove(A_1))
		{
			this.h(A_0);
			this.a(A_0, A_1);
		}
	}

	// Token: 0x0600091B RID: 2331 RVA: 0x00025BD8 File Offset: 0x00023DD8
	public void UnregisterHandlers<T>() where T : dli
	{
		if (this.a.Remove(typeof(T)))
		{
			this.h(typeof(T));
		}
		this.b(typeof(T));
	}

	// Token: 0x0600091C RID: 2332 RVA: 0x00025C14 File Offset: 0x00023E14
	public void ao5()
	{
		if (this.a.Count > 0)
		{
			this.d();
			this.a.Clear();
		}
		this.c();
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x00025C40 File Offset: 0x00023E40
	public void ao6(dli A_0)
	{
		if (A_0 == null)
		{
			this.b();
			return;
		}
		IList<b61> list = this.f(A_0.GetType());
		if (this.c)
		{
			foreach (b61 b in list)
			{
				if (b.b(A_0))
				{
					b.a(A_0);
				}
			}
			this.a(A_0, list.Count);
			return;
		}
		this.a(A_0);
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x00025CD8 File Offset: 0x00023ED8
	private List<b61> i(Type A_0)
	{
		List<b61> list;
		this.a.TryGetValue(A_0, out list);
		if (list == null)
		{
			list = new List<b61>();
			this.a.Add(A_0, list);
		}
		return list;
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x00025D10 File Offset: 0x00023F10
	private void d()
	{
		this.b.Clear();
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x00025D20 File Offset: 0x00023F20
	private void h(Type A_0)
	{
		List<Type> list = new List<Type>();
		foreach (KeyValuePair<Type, IList<b61>> keyValuePair in this.b)
		{
			if (keyValuePair.Key.IsAssignableFrom(A_0) || keyValuePair.Key.IsSubclassOf(A_0))
			{
				list.Add(keyValuePair.Key);
			}
		}
		foreach (Type key in list)
		{
			this.b.Remove(key);
		}
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x00025DF4 File Offset: 0x00023FF4
	private IList<b61> g(Type A_0)
	{
		SortedList<Type, b61> sortedList = new SortedList<Type, b61>(dq1.a.a());
		foreach (KeyValuePair<Type, List<b61>> keyValuePair in this.a)
		{
			if (keyValuePair.Key.IsAssignableFrom(A_0) && keyValuePair.Value != null)
			{
				foreach (b61 b in keyValuePair.Value)
				{
					sortedList.Add(keyValuePair.Key, b);
				}
			}
		}
		return sortedList.Values;
	}

	// Token: 0x06000922 RID: 2338 RVA: 0x00025EC8 File Offset: 0x000240C8
	private IList<b61> f(Type A_0)
	{
		IList<b61> list = null;
		this.b.TryGetValue(A_0, out list);
		if (list == null)
		{
			list = this.g(A_0);
			this.b.Add(A_0, list);
		}
		return list;
	}

	// Token: 0x06000923 RID: 2339 RVA: 0x00025F04 File Offset: 0x00024104
	private bool e(Type A_0)
	{
		if (A_0 == null)
		{
			this.a();
			return false;
		}
		if (!typeof(dli).IsAssignableFrom(A_0))
		{
			this.a(A_0);
			return false;
		}
		return true;
	}

	// Token: 0x06000924 RID: 2340 RVA: 0x00025F3C File Offset: 0x0002413C
	private void b(Type A_0, b61 A_1)
	{
		if (this.d != null && this.d.n8() && this.d.n9(LogSeverity.Information, 116))
		{
			string a_ = string.Format("[Global Event Aggregator] - New event handler registered for event of type '{0}': {1}", A_0.FullName, A_1.ToString());
			this.d.n7(LogSeverity.Information, 116, a_);
		}
	}

	// Token: 0x06000925 RID: 2341 RVA: 0x00025FA0 File Offset: 0x000241A0
	private void a(Type A_0, b61 A_1)
	{
		if (this.d != null && this.d.n8() && this.d.n9(LogSeverity.Information, 116))
		{
			string a_ = string.Format("[Global Event Aggregator] - Event handler unregistered for event of type '{0}': {1}", A_0.FullName, A_1.ToString());
			this.d.n7(LogSeverity.Information, 116, a_);
		}
	}

	// Token: 0x06000926 RID: 2342 RVA: 0x00026004 File Offset: 0x00024204
	private void d(Type A_0)
	{
		if (this.d != null && this.d.n8() && this.d.n9(LogSeverity.Error, 116))
		{
			string a_ = string.Format("[Global Event Aggregator] - Attempted to register null event handler for event type '{0}'.", A_0);
			this.d.n7(LogSeverity.Error, 116, a_);
		}
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x0002605C File Offset: 0x0002425C
	private void c(Type A_0)
	{
		if (this.d != null && this.d.n8() && this.d.n9(LogSeverity.Error, 116))
		{
			string a_ = string.Format("[Global Event Aggregator] - Attempted to unregister null event handler for event type '{0}'.", A_0);
			this.d.n7(LogSeverity.Error, 116, a_);
		}
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x000260B4 File Offset: 0x000242B4
	private void b(Type A_0)
	{
		if (this.d != null && this.d.n8() && this.d.n9(LogSeverity.Information, 116))
		{
			string a_ = string.Format("[Global Event Aggregator] - All handlers for event type '{0}' unregistered.", A_0);
			this.d.n7(LogSeverity.Information, 116, a_);
		}
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x0002610C File Offset: 0x0002430C
	private void c()
	{
		if (this.d != null && this.d.n8() && this.d.n9(LogSeverity.Information, 116))
		{
			string a_ = "[Global Event Aggregator] - All handlers unregistered.";
			this.d.n7(LogSeverity.Information, 116, a_);
		}
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x0002615C File Offset: 0x0002435C
	private void a(dli A_0, int A_1)
	{
		if (this.d != null && this.d.n8() && this.d.n9(LogSeverity.Verbose, 116))
		{
			string a_ = string.Format("[Global Event Aggregator] - Event '{0}' published to total of {1} handlers.", A_0, A_1);
			this.d.n7(LogSeverity.Verbose, 116, a_);
		}
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x000261B8 File Offset: 0x000243B8
	private void a(dli A_0)
	{
		if (this.d != null && this.d.n8() && this.d.n9(LogSeverity.Verbose, 116))
		{
			string a_ = string.Format("[Global Event Aggregator] - Event '{0}' not published because Global Event Aggregator is disabled.", A_0);
			this.d.n7(LogSeverity.Verbose, 116, a_);
		}
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x00026210 File Offset: 0x00024410
	private void b()
	{
		if (this.d != null && this.d.n8() && this.d.n9(LogSeverity.Error, 116))
		{
			string a_ = "[Global Event Aggregator] - Attempted to publish a null event.";
			this.d.n7(LogSeverity.Error, 116, a_);
		}
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x00026260 File Offset: 0x00024460
	private void a(Type A_0)
	{
		if (this.d != null && this.d.n8() && this.d.n9(LogSeverity.Error, 116))
		{
			string a_ = string.Format("[Global Event Aggregator] - Type '{0}' is not a valid event type as it does not inherit from '{1}'.", A_0.FullName, typeof(dli).FullName);
			this.d.n7(LogSeverity.Error, 116, a_);
		}
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x000262CC File Offset: 0x000244CC
	private void a()
	{
		if (this.d != null && this.d.n8() && this.d.n9(LogSeverity.Error, 116))
		{
			string a_ = "[Global Event Aggregator] - Null event type passed.";
			this.d.n7(LogSeverity.Error, 116, a_);
		}
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x0002631C File Offset: 0x0002451C
	public override string ToString()
	{
		return string.Format("Enabled: {0}. Event types count: {1}.", this.c, this.a.Count);
	}

	// Token: 0x040005DD RID: 1501
	private Dictionary<Type, List<b61>> a = new Dictionary<Type, List<b61>>();

	// Token: 0x040005DE RID: 1502
	private Dictionary<Type, IList<b61>> b = new Dictionary<Type, IList<b61>>();

	// Token: 0x040005DF RID: 1503
	private bool c = true;

	// Token: 0x040005E0 RID: 1504
	private cvq d;

	// Token: 0x0200016A RID: 362
	private class a : IComparer<Type>
	{
		// Token: 0x06000930 RID: 2352 RVA: 0x00026344 File Offset: 0x00024544
		public static dq1.a a()
		{
			return dq1.a.a;
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0002634C File Offset: 0x0002454C
		public int Compare(Type x, Type y)
		{
			if (y.IsSubclassOf(x))
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x040005E1 RID: 1505
		private static dq1.a a = new dq1.a();
	}
}
