using System;
using System.Runtime.Serialization;

// Token: 0x02001A42 RID: 6722
[eiz("MWACBE")]
[Serializable]
public sealed class cex : dh6, ISerializable
{
	// Token: 0x060091DB RID: 37339 RVA: 0x0039DE88 File Offset: 0x0039C088
	private cex(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060091DC RID: 37340 RVA: 0x0039DE94 File Offset: 0x0039C094
	public cex()
	{
	}

	// Token: 0x060091DD RID: 37341 RVA: 0x0039DE9C File Offset: 0x0039C09C
	public cex(float A_0) : base(A_0)
	{
	}

	// Token: 0x060091DE RID: 37342 RVA: 0x0039DEA8 File Offset: 0x0039C0A8
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		if (A_0.a() != null)
		{
			dcu dcu = A_0.a().Offense;
			dcu.g(dcu.am() + Math.Round((double)base.c(), 2));
		}
	}

	// Token: 0x060091DF RID: 37343 RVA: 0x0039DEF0 File Offset: 0x0039C0F0
	public override string b2()
	{
		if (base.c() >= 0f)
		{
			return string.Format("Бонус критического урона увеличен на {0}%", base.c() * 100f);
		}
		return string.Format("Бонус критического урона уменьшен на {0}%", Math.Abs(base.c()) * 100f);
	}

	// Token: 0x060091E0 RID: 37344 RVA: 0x0039DF4C File Offset: 0x0039C14C
	public override d3e b3()
	{
		cex cex = new cex();
		this.xx(cex);
		return cex;
	}
}
