using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000113 RID: 275
[eiz("CA")]
[Serializable]
public abstract class di6 : btm, ISerializable
{
	// Token: 0x06000694 RID: 1684 RVA: 0x0001BC58 File Offset: 0x00019E58
	protected di6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			di7.ReadList<btm>("CA:A", ref this.a, A_0);
			di7.ReadList<btm>("CA:CAA", ref this.b, A_0);
			di7.ReadList<btm>("CA:CAA1", ref this.c, A_0);
			di7.ReadList<btm>("CA:FAA", ref this.d, A_0);
			di7.ReadList<btm>("CA:CA", ref this.e, A_0);
			return;
		}
		if (base.GetType() == typeof(di6))
		{
			this.a = (List<btm>)A_0.GetValue("_Activities", typeof(List<btm>));
			this.b = (List<btm>)A_0.GetValue("_CurrentAsyncActivities", typeof(List<btm>));
			this.c = (List<btm>)A_0.GetValue("_CompletedAsyncActivities", typeof(List<btm>));
			this.d = (List<btm>)A_0.GetValue("_FailedAsyncActivities", typeof(List<btm>));
			this.e = (List<btm>)A_0.GetValue("_CompletedActivities", typeof(List<btm>));
			return;
		}
		this.a = (List<btm>)A_0.GetValue("CompositeActivity+_Activities", typeof(List<btm>));
		this.b = (List<btm>)A_0.GetValue("CompositeActivity+_CurrentAsyncActivities", typeof(List<btm>));
		this.c = (List<btm>)A_0.GetValue("CompositeActivity+_CompletedAsyncActivities", typeof(List<btm>));
		this.d = (List<btm>)A_0.GetValue("CompositeActivity+_FailedAsyncActivities", typeof(List<btm>));
		this.e = (List<btm>)A_0.GetValue("CompositeActivity+_CompletedActivities", typeof(List<btm>));
	}

	// Token: 0x06000695 RID: 1685 RVA: 0x0001BE60 File Offset: 0x0001A060
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<btm>("CA:A", this.a, info);
		di7.WriteList<btm>("CA:CAA", this.b, info);
		di7.WriteList<btm>("CA:CAA1", this.c, info);
		di7.WriteList<btm>("CA:FAA", this.d, info);
		di7.WriteList<btm>("CA:CA", this.e, info);
	}

	// Token: 0x06000696 RID: 1686 RVA: 0x0001BECC File Offset: 0x0001A0CC
	public List<btm> f()
	{
		return this.a;
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x0001BED4 File Offset: 0x0001A0D4
	protected List<btm> c()
	{
		return this.b;
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x0001BEDC File Offset: 0x0001A0DC
	protected List<btm> e()
	{
		return this.c;
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x0001BEE4 File Offset: 0x0001A0E4
	protected List<btm> g()
	{
		return this.d;
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x0001BEEC File Offset: 0x0001A0EC
	public List<btm> d()
	{
		return this.e;
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x0001BEF8 File Offset: 0x0001A0F8
	protected di6(params btm[] A_0) : base(null)
	{
		this.a(A_0);
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x0001BF4C File Offset: 0x0001A14C
	protected di6(string A_0, params btm[] A_1) : base(A_0)
	{
		this.a(A_1);
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x0001BFA0 File Offset: 0x0001A1A0
	public void a(params btm[] A_0)
	{
		czh.a(A_0, "activities");
		foreach (btm btm in A_0)
		{
			btm.Parent = this;
			this.f().Add(btm);
		}
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x0001BFE8 File Offset: 0x0001A1E8
	public void a(int A_0, params btm[] A_1)
	{
		czh.a(A_1, "activities");
		for (int i = 0; i < A_1.Length; i++)
		{
			A_1[i].Parent = this;
		}
		this.f().InsertRange(A_0, A_1);
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x0001C030 File Offset: 0x0001A230
	protected override bool b4(e6d A_0)
	{
		if (this.a == null)
		{
			this.a = new List<btm>();
		}
		if (this.b != null)
		{
			this.b.Clear();
		}
		if (this.c != null)
		{
			this.c.Clear();
		}
		this.e.Clear();
		return false;
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x0001C08C File Offset: 0x0001A28C
	protected override bool aen(e6d A_0)
	{
		bool flag = base.aen(A_0);
		bool flag2 = this.a(A_0);
		return flag && flag2;
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x0001C0AC File Offset: 0x0001A2AC
	protected void b(btm A_0)
	{
		if (this.a.Contains(A_0))
		{
			this.b.Add(A_0);
		}
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x0001C0CC File Offset: 0x0001A2CC
	protected void a(btm A_0)
	{
		if (this.a.Contains(A_0))
		{
			this.e.Add(A_0);
		}
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x0001C0EC File Offset: 0x0001A2EC
	protected override void aep(e6d A_0)
	{
		if (this.b != null)
		{
			foreach (btm btm in this.b)
			{
				btm.g(A_0);
			}
		}
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x0001C150 File Offset: 0x0001A350
	protected override void aeq(e6d A_0)
	{
		if (this.b != null)
		{
			foreach (btm btm in this.b)
			{
				btm.e(A_0);
			}
		}
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x0001C1B4 File Offset: 0x0001A3B4
	private bool a(e6d A_0)
	{
		bool result = true;
		if (this.b != null && this.b.Count > 0)
		{
			List<btm> list = new List<btm>();
			List<btm> list2 = new List<btm>();
			foreach (btm btm in this.b)
			{
				cdv cdv = btm.f(A_0);
				if (cdv == cdv.c)
				{
					list2.Add(btm);
				}
				else if (cdv == cdv.b)
				{
					list.Add(btm);
				}
				else
				{
					result = false;
				}
			}
			foreach (btm item in list2)
			{
				this.b.Remove(item);
				this.d.Add(item);
			}
			foreach (btm item2 in list)
			{
				this.b.Remove(item2);
				this.c.Add(item2);
			}
		}
		return result;
	}

	// Token: 0x04000524 RID: 1316
	private List<btm> a = new List<btm>();

	// Token: 0x04000525 RID: 1317
	private List<btm> b = new List<btm>();

	// Token: 0x04000526 RID: 1318
	private List<btm> c = new List<btm>();

	// Token: 0x04000527 RID: 1319
	private new List<btm> d = new List<btm>();

	// Token: 0x04000528 RID: 1320
	private new List<btm> e = new List<btm>();
}
