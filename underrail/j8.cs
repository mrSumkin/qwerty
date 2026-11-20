using System;
using System.Runtime.Serialization;

// Token: 0x020007BD RID: 1981
[eiz("GCGPC")]
[Serializable]
public sealed class j8 : dnh, ISerializable
{
	// Token: 0x06003195 RID: 12693 RVA: 0x0012FC90 File Offset: 0x0012DE90
	private j8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("GCGPC:MV");
	}

	// Token: 0x06003196 RID: 12694 RVA: 0x0012FCAC File Offset: 0x0012DEAC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GCGPC:MV", this.a);
	}

	// Token: 0x06003197 RID: 12695 RVA: 0x0012FCC8 File Offset: 0x0012DEC8
	public int a()
	{
		return this.a;
	}

	// Token: 0x06003198 RID: 12696 RVA: 0x0012FCD0 File Offset: 0x0012DED0
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003199 RID: 12697 RVA: 0x0012FCDC File Offset: 0x0012DEDC
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			int num = serviceOrThrow.aqu().v().Skills.Get<bhn>().g();
			if (am9.a())
			{
				this.b += 80;
			}
			else if (am9.c())
			{
				this.b += 60;
			}
			else if (am9.d())
			{
				this.b += 40;
			}
			return num >= this.a + this.b;
		}
		return false;
	}

	// Token: 0x0600319A RID: 12698 RVA: 0x0012FD90 File Offset: 0x0012DF90
	public override string ToString()
	{
		return string.Format("Persuasion >= {0}", this.a + this.b);
	}

	// Token: 0x0600319B RID: 12699 RVA: 0x0012FDB0 File Offset: 0x0012DFB0
	public j8()
	{
	}

	// Token: 0x04001AB5 RID: 6837
	private int a;

	// Token: 0x04001AB6 RID: 6838
	private int b;
}
