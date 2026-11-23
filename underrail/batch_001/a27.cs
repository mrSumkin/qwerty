using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200142E RID: 5166
[eiz("RHA")]
[Serializable]
public sealed class a27 : b1z, ISerializable
{
	// Token: 0x060073CD RID: 29645 RVA: 0x0030E918 File Offset: 0x0030CB18
	private a27(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("RHA:SR", typeof(EntityAspectReference<amc, amc>));
		this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("RHA:TR", typeof(EntityAspectReference<amc, amc>));
		this.c = A_0.GetBoolean("RHA:DS");
		this.d = A_0.GetBoolean("RHA:DT");
		if (ell.a() >= 184)
		{
			this.f = A_0.GetBoolean("RHA:Y");
		}
		if (ell.a() >= 256)
		{
			this.e = A_0.GetBoolean("RHA:I");
			return;
		}
		this.e = true;
	}

	// Token: 0x060073CE RID: 29646 RVA: 0x0030E9D8 File Offset: 0x0030CBD8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RHA:SR", this.a);
		info.AddValue("RHA:TR", this.b);
		info.AddValue("RHA:DS", this.c);
		info.AddValue("RHA:DT", this.d);
		info.AddValue("RHA:Y", this.f);
		info.AddValue("RHA:I", this.e);
	}

	// Token: 0x060073CF RID: 29647 RVA: 0x0030EA54 File Offset: 0x0030CC54
	public a27(amc A_0, amc A_1, bool A_2, bool A_3, bool A_4 = false, bool A_5 = true)
	{
		if (A_0 != null)
		{
			this.a = new EntityAspectReference<amc, amc>(A_0);
		}
		if (A_1 != null)
		{
			this.b = new EntityAspectReference<amc, amc>(A_1);
		}
		this.c = A_2;
		this.d = A_3;
		this.f = A_4;
		this.e = A_5;
	}

	// Token: 0x060073D0 RID: 29648 RVA: 0x0030EAAC File Offset: 0x0030CCAC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		awq.a(this.a.ao(), this.b.ao(), this.c, this.d, null, true, this.e, this.f, false);
		return dc4.c;
	}

	// Token: 0x04002F52 RID: 12114
	private new EntityAspectReference<amc, amc> a;

	// Token: 0x04002F53 RID: 12115
	private EntityAspectReference<amc, amc> b;

	// Token: 0x04002F54 RID: 12116
	private bool c;

	// Token: 0x04002F55 RID: 12117
	private bool d;

	// Token: 0x04002F56 RID: 12118
	private bool e;

	// Token: 0x04002F57 RID: 12119
	private bool f;
}
