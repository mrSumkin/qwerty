using System;
using System.Runtime.Serialization;

// Token: 0x02000148 RID: 328
[eiz("A3")]
[Serializable]
public class atr : dzc, ISerializable
{
	// Token: 0x06000819 RID: 2073 RVA: 0x00022444 File Offset: 0x00020644
	protected atr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetBoolean("A3:ID");
			if (ell.b() >= 14)
			{
				this.b = A_0.GetBoolean("A3:D");
				if (ell.b() >= 15)
				{
					this.c = (A_0.GetValue("A3:DC", typeof(dnh)) as dnh);
					if (ell.b() >= 41)
					{
						this.d = A_0.GetValue("A3:T", typeof(object));
						return;
					}
				}
			}
		}
		else
		{
			if (base.GetType() == typeof(atr))
			{
				this.a = A_0.GetBoolean("_IsDefault");
				return;
			}
			this.a = A_0.GetBoolean("Answer+_IsDefault");
		}
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x00022524 File Offset: 0x00020724
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("A3:ID", this.a);
		info.AddValue("A3:D", this.b);
		info.AddValue("A3:DC", this.c);
		info.AddValue("A3:T", this.d);
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x00022580 File Offset: 0x00020780
	public bool a()
	{
		return this.a;
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x00022588 File Offset: 0x00020788
	public void b(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x00022594 File Offset: 0x00020794
	public new bool d()
	{
		return this.b;
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x0002259C File Offset: 0x0002079C
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x000225A8 File Offset: 0x000207A8
	public dnh b()
	{
		return this.c;
	}

	// Token: 0x06000820 RID: 2080 RVA: 0x000225B0 File Offset: 0x000207B0
	public void a(dnh A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x000225BC File Offset: 0x000207BC
	public object c()
	{
		return this.d;
	}

	// Token: 0x06000822 RID: 2082 RVA: 0x000225C4 File Offset: 0x000207C4
	public void a(object A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x000225D0 File Offset: 0x000207D0
	public atr()
	{
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x000225D8 File Offset: 0x000207D8
	public atr(string A_0) : base(A_0)
	{
	}

	// Token: 0x04000592 RID: 1426
	private new bool a;

	// Token: 0x04000593 RID: 1427
	private new bool b;

	// Token: 0x04000594 RID: 1428
	private new dnh c;

	// Token: 0x04000595 RID: 1429
	private new object d;
}
