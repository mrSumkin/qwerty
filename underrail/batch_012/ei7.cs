using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012C8 RID: 4808
[eiz("XC")]
[Serializable]
public sealed class ei7 : Aspect<c5x>, cmm, ISerializable
{
	// Token: 0x06006A21 RID: 27169 RVA: 0x002CBF98 File Offset: 0x002CA198
	private ei7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("XC:B");
		this.b = (A_0.GetValue("XC:R", typeof(TimeSpan?)) as TimeSpan?);
		this.c = A_0.GetDouble("XC:C");
	}

	// Token: 0x06006A22 RID: 27170 RVA: 0x002CC00C File Offset: 0x002CA20C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XC:B", this.a);
		info.AddValue("XC:R", this.b);
		info.AddValue("XC:C", this.c);
	}

	// Token: 0x06006A23 RID: 27171 RVA: 0x002CC05C File Offset: 0x002CA25C
	public bool d()
	{
		return this.a;
	}

	// Token: 0x06006A24 RID: 27172 RVA: 0x002CC064 File Offset: 0x002CA264
	public void b(bool A_0)
	{
		this.a(A_0);
	}

	// Token: 0x06006A25 RID: 27173 RVA: 0x002CC070 File Offset: 0x002CA270
	public TimeSpan? b()
	{
		return this.b;
	}

	// Token: 0x06006A26 RID: 27174 RVA: 0x002CC078 File Offset: 0x002CA278
	public void a(TimeSpan? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006A27 RID: 27175 RVA: 0x002CC084 File Offset: 0x002CA284
	public double a()
	{
		return this.c;
	}

	// Token: 0x06006A28 RID: 27176 RVA: 0x002CC08C File Offset: 0x002CA28C
	public void a(double A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006A29 RID: 27177 RVA: 0x002CC098 File Offset: 0x002CA298
	public ei7(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006A2A RID: 27178 RVA: 0x002CC0B8 File Offset: 0x002CA2B8
	public void c9(TimeSpan A_0)
	{
	}

	// Token: 0x06006A2B RID: 27179 RVA: 0x002CC0C0 File Offset: 0x002CA2C0
	public void da(TimeSpan A_0)
	{
		if (!this.a)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && !this.a && this.b != null && serviceOrThrow.aqu().p() >= this.b.Value)
			{
				this.b = null;
				this.a(true);
			}
		}
	}

	// Token: 0x06006A2C RID: 27180 RVA: 0x002CC138 File Offset: 0x002CA338
	public void r7(eds A_0)
	{
	}

	// Token: 0x06006A2D RID: 27181 RVA: 0x002CC140 File Offset: 0x002CA340
	private void a(bool A_0)
	{
		this.a = A_0;
		if (base.a8().o.b != null && !string.IsNullOrEmpty(base.a8().o.b.a))
		{
			if (this.a && base.a8().o.b.a.EndsWith("dep", StringComparison.OrdinalIgnoreCase))
			{
				base.a8().o.b.a = base.a8().o.b.a.Substring(0, base.a8().o.b.a.Length - 3);
			}
			else if (!this.a && !base.a8().o.b.a.EndsWith("dep", StringComparison.OrdinalIgnoreCase))
			{
				cd0 cd = base.a8().o.b;
				cd.a += "dep";
			}
		}
		if (base.a8().s.b != null)
		{
			base.a8().s.b.g(this.a);
		}
	}

	// Token: 0x04002BA5 RID: 11173
	private bool a = true;

	// Token: 0x04002BA6 RID: 11174
	private TimeSpan? b;

	// Token: 0x04002BA7 RID: 11175
	private double c = 0.2;
}
