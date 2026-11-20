using System;
using System.Collections.Generic;
using System.Linq;
using Ouroboros.Core.Logging;

// Token: 0x02000128 RID: 296
internal sealed class e1s : d4m
{
	// Token: 0x06000710 RID: 1808 RVA: 0x0001CAE4 File Offset: 0x0001ACE4
	public btm avo()
	{
		return this.c;
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x0001CAEC File Offset: 0x0001ACEC
	public void avp(btm A_0)
	{
		czh.a(A_0, "activity");
		this.a.Enqueue(A_0);
		this.d(A_0);
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x0001CB10 File Offset: 0x0001AD10
	public void avq(btm A_0)
	{
		czh.a(A_0, "activity");
		if (this.c == A_0)
		{
			this.b(this.c);
			this.c = null;
		}
		if (!this.b.Contains(A_0) && this.a.Contains(A_0))
		{
			this.b.Add(A_0);
			e1s.c(A_0);
		}
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x0001CB7C File Offset: 0x0001AD7C
	public void avr()
	{
		foreach (btm a_ in Enumerable.ToList<btm>(this.a))
		{
			this.avq(a_);
		}
		if (this.c != null)
		{
			this.avq(this.c);
		}
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x0001CBF4 File Offset: 0x0001ADF4
	public void b(e6d A_0)
	{
		if (this.c == null)
		{
			this.a(A_0);
			return;
		}
		bool flag = true;
		try
		{
			cdv cdv = this.c.f(A_0);
			if (cdv == cdv.b)
			{
				this.a(this.c);
			}
			else if (cdv == cdv.a)
			{
				flag = false;
			}
		}
		catch (Exception a_)
		{
			e1s.a(this.c, a_);
			throw;
		}
		if (flag)
		{
			this.a(A_0);
		}
	}

	// Token: 0x06000715 RID: 1813 RVA: 0x0001CC74 File Offset: 0x0001AE74
	private void a(e6d A_0)
	{
		while (this.a.Count > 0)
		{
			this.c = this.a.Dequeue();
			if (!this.b.Remove(this.c))
			{
				try
				{
					cdv cdv = this.c.d(A_0);
					if (cdv == cdv.a)
					{
						return;
					}
					if (cdv == cdv.b)
					{
						this.a(this.c);
					}
				}
				catch (Exception a_)
				{
					e1s.b(this.c, a_);
				}
				continue;
			}
			this.b(this.c);
		}
		this.c = null;
	}

	// Token: 0x06000716 RID: 1814 RVA: 0x0001CD2C File Offset: 0x0001AF2C
	private void d(btm A_0)
	{
		cvq cvq = dr3.e();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 117))
		{
			string a_ = string.Format("[Workflow Manager] - New activity queued: '{0}'. Number of activities in queue: {1}", A_0.ToString(), this.a.Count);
			cvq.n7(LogSeverity.Information, 117, a_);
		}
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x0001CD8C File Offset: 0x0001AF8C
	private static void b(btm A_0, Exception A_1)
	{
		cvq cvq = dr3.e();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 117))
		{
			string a_ = string.Format("[Workflow Manager] - Error occurred while starting queued activity '{0}' and was propagated to the manager. Exception: {1}.", A_0.ToString(), A_1.ToString());
			cvq.n7(LogSeverity.Error, 117, a_);
		}
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x0001CDE0 File Offset: 0x0001AFE0
	private static void a(btm A_0, Exception A_1)
	{
		cvq cvq = dr3.e();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 117))
		{
			string a_ = string.Format("[Workflow Manager] - Error occurred while updating activity '{0}' and was propagated to the manager. Exception: {1}.", A_0.ToString(), A_1.ToString());
			cvq.n7(LogSeverity.Error, 117, a_);
		}
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x0001CE34 File Offset: 0x0001B034
	private static void c(btm A_0)
	{
		cvq cvq = dr3.e();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 117))
		{
			string a_ = string.Format("[Workflow Manager] - Activity '{0}' marked for cancellation.", A_0.ToString());
			cvq.n7(LogSeverity.Information, 117, a_);
		}
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x0001CE84 File Offset: 0x0001B084
	private void b(btm A_0)
	{
		cvq cvq = dr3.e();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 117))
		{
			string a_ = string.Format("[Workflow Manager] - Activity '{0}' was cancelled. Remaining activities in queue: {1}", A_0.ToString(), this.a.Count);
			cvq.n7(LogSeverity.Information, 117, a_);
		}
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x0001CEE4 File Offset: 0x0001B0E4
	private void a(btm A_0)
	{
		cvq cvq = dr3.e();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 117))
		{
			string a_ = string.Format("[Workflow Manager] - Activity '{0}' was completed. Remaining activities in queue: {1}", A_0.ToString(), this.a.Count);
			cvq.n7(LogSeverity.Information, 117, a_);
		}
	}

	// Token: 0x04000543 RID: 1347
	private Queue<btm> a = new Queue<btm>();

	// Token: 0x04000544 RID: 1348
	private List<btm> b = new List<btm>();

	// Token: 0x04000545 RID: 1349
	private btm c;
}
