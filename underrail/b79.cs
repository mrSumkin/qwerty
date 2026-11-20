using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020011DF RID: 4575
[eiz("STTG")]
[Serializable]
public abstract class b79 : ya, ISerializable
{
	// Token: 0x06006223 RID: 25123 RVA: 0x002A7FE0 File Offset: 0x002A61E0
	protected b79(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 364)
		{
			this.a = (A_0.GetValue("STTG:N", typeof(TimeSpan?)) as TimeSpan?);
			this.b = (TimeSpan)A_0.GetValue("STTG:R", typeof(TimeSpan));
			this.d = A_0.GetInt32("STTG:D");
			di7.ReadList<cze>("STTG:J", ref this.c, A_0);
			if (ell.a() >= 482)
			{
				this.e = (A_0.GetValue("STTG:I", typeof(TimeSpan?)) as TimeSpan?);
				return;
			}
		}
		else
		{
			this.c = new List<cze>();
		}
	}

	// Token: 0x06006224 RID: 25124 RVA: 0x002A80B8 File Offset: 0x002A62B8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("STTG:N", this.a);
		info.AddValue("STTG:R", this.b);
		di7.WriteList<cze>("STTG:J", this.c, info);
		info.AddValue("STTG:D", this.d);
		info.AddValue("STTG:I", this.e);
	}

	// Token: 0x06006225 RID: 25125 RVA: 0x002A8134 File Offset: 0x002A6334
	public TimeSpan? g()
	{
		return this.a;
	}

	// Token: 0x06006226 RID: 25126 RVA: 0x002A813C File Offset: 0x002A633C
	public void b(TimeSpan? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006227 RID: 25127 RVA: 0x002A8148 File Offset: 0x002A6348
	public TimeSpan h()
	{
		return this.b;
	}

	// Token: 0x06006228 RID: 25128 RVA: 0x002A8150 File Offset: 0x002A6350
	public void a(TimeSpan A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006229 RID: 25129 RVA: 0x002A815C File Offset: 0x002A635C
	public List<cze> f()
	{
		return this.c;
	}

	// Token: 0x0600622A RID: 25130 RVA: 0x002A8164 File Offset: 0x002A6364
	public void a(List<cze> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600622B RID: 25131 RVA: 0x002A8170 File Offset: 0x002A6370
	public int e()
	{
		return this.d;
	}

	// Token: 0x0600622C RID: 25132 RVA: 0x002A8178 File Offset: 0x002A6378
	public void b(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600622D RID: 25133 RVA: 0x002A8184 File Offset: 0x002A6384
	public TimeSpan? d()
	{
		return this.e;
	}

	// Token: 0x0600622E RID: 25134 RVA: 0x002A818C File Offset: 0x002A638C
	public void a(TimeSpan? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600622F RID: 25135 RVA: 0x002A8198 File Offset: 0x002A6398
	public b79()
	{
	}

	// Token: 0x06006230 RID: 25136 RVA: 0x002A81B0 File Offset: 0x002A63B0
	protected override void jk(b0b A_0)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.IsPlayer)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				if (this.a == null && this.e != null)
				{
					double value = this.e.Value.TotalMilliseconds * cuo.a.NextDouble();
					this.a = new TimeSpan?(serviceOrThrow.aqu().p() + TimeSpan.FromMilliseconds(value));
					return;
				}
				if (this.a == null || this.a.Value < serviceOrThrow.aqu().p())
				{
					this.a = new TimeSpan?(serviceOrThrow.aqu().p() + this.b);
					this.li();
					if (this.c.Count > 0 && base.Area != null && base.Area.Zone != null)
					{
						qy qy = new qy();
						qy.b(false);
						qy.c(false);
						if (this.d > 0)
						{
							qy.ad().Add(new bm3(this.d));
						}
						foreach (cze a_ in this.c)
						{
							qy.ad().Add(new a4s(a_, new ar7(A_0), new ar7(A_0), null));
						}
						base.Area.Zone.ActionManager.g9(qy, atp.a);
					}
				}
			}
		}
	}

	// Token: 0x06006231 RID: 25137
	protected abstract void li();

	// Token: 0x0400299B RID: 10651
	private TimeSpan? a;

	// Token: 0x0400299C RID: 10652
	private TimeSpan b;

	// Token: 0x0400299D RID: 10653
	private List<cze> c = new List<cze>();

	// Token: 0x0400299E RID: 10654
	private new int d;

	// Token: 0x0400299F RID: 10655
	private new TimeSpan? e;
}
