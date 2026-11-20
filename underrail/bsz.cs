using System;
using System.Runtime.Serialization;

// Token: 0x02001354 RID: 4948
[eiz("UPA")]
[Serializable]
public sealed class bsz : b1z, ISerializable
{
	// Token: 0x06007000 RID: 28672 RVA: 0x002F04A8 File Offset: 0x002EE6A8
	private bsz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("UPA:TER", typeof(ar7)) as ar7);
		this.b = (abo)A_0.GetValue("UPA:PG", typeof(abo));
		this.c = A_0.GetInt32("UPA:PD");
		this.d = A_0.GetDouble("UPA:TTP");
	}

	// Token: 0x06007001 RID: 28673 RVA: 0x002F0520 File Offset: 0x002EE720
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("UPA:TER", this.a);
		info.AddValue("UPA:PG", this.b);
		info.AddValue("UPA:PD", this.c);
		info.AddValue("UPA:TTP", this.d);
	}

	// Token: 0x06007002 RID: 28674 RVA: 0x002F0580 File Offset: 0x002EE780
	public bsz(b0b A_0, abo A_1, int A_2)
	{
		if (A_0 != null)
		{
			this.a = new ar7(A_0);
		}
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x06007003 RID: 28675 RVA: 0x002F05AC File Offset: 0x002EE7AC
	protected override dc4 dt()
	{
		if (this.a == null || this.a.ao() == null || this.a.ao().Zone == null || this.b.a == null)
		{
			return dc4.e;
		}
		this.d = (double)this.c;
		d5q d5q = this.a();
		if (d5q != null && d5q.kc(this.a.ao() as c5x, this.b))
		{
			return dc4.b;
		}
		return dc4.e;
	}

	// Token: 0x06007004 RID: 28676 RVA: 0x002F063C File Offset: 0x002EE83C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null || this.a.ao() == null || this.a.ao().Zone == null || this.b.a == null)
		{
			return dc4.e;
		}
		if (this.d > 0.0 && (this.d -= A_1.TotalMilliseconds) > 0.0)
		{
			return dc4.b;
		}
		d5q d5q = this.a();
		if (d5q != null && d5q.afu(this.a.ao() as c5x, this.b))
		{
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x06007005 RID: 28677 RVA: 0x002F06F8 File Offset: 0x002EE8F8
	private d5q a()
	{
		d5s addon = this.a.ao().Zone.GetAddon<d5s>();
		if (addon != null)
		{
			d5q d5q = addon.aj3(this.b.a);
			if (d5q == null)
			{
				d5q = new bsz.a();
			}
			return d5q;
		}
		return null;
	}

	// Token: 0x04002DC0 RID: 11712
	private new ar7 a;

	// Token: 0x04002DC1 RID: 11713
	private abo b;

	// Token: 0x04002DC2 RID: 11714
	private int c;

	// Token: 0x04002DC3 RID: 11715
	private double d;

	// Token: 0x02001355 RID: 4949
	private new sealed class a : d5q
	{
		// Token: 0x06007006 RID: 28678 RVA: 0x002F0744 File Offset: 0x002EE944
		public bool kc(c5x A_0, abo A_1)
		{
			return true;
		}

		// Token: 0x06007007 RID: 28679 RVA: 0x002F074C File Offset: 0x002EE94C
		public bool afu(c5x A_0, abo A_1)
		{
			abo abo = A_1.a();
			aud aud = A_0.Zone.b(abo.c.b);
			if (aud == null)
			{
				if (A_0.Area == null)
				{
					return false;
				}
				aud = A_0.Area;
			}
			a0l.a(A_0, aud, abo.c.a.a() / 4f, abo.g, false);
			return true;
		}
	}
}
