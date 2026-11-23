using System;
using System.Runtime.Serialization;

// Token: 0x02001293 RID: 4755
[eiz("TRPEA")]
[a(typeof(c5i))]
[Serializable]
public sealed class bi9 : c5i, ISerializable
{
	// Token: 0x060067D4 RID: 26580 RVA: 0x002BFACC File Offset: 0x002BDCCC
	private bi9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("TRPEA:R");
	}

	// Token: 0x060067D5 RID: 26581 RVA: 0x002BFAF0 File Offset: 0x002BDCF0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TRPEA:R", this.a);
	}

	// Token: 0x060067D6 RID: 26582 RVA: 0x002BFB0C File Offset: 0x002BDD0C
	public int b()
	{
		return this.a;
	}

	// Token: 0x060067D7 RID: 26583 RVA: 0x002BFB14 File Offset: 0x002BDD14
	public void a(int A_0)
	{
		this.a = d05.a(1, A_0, 3);
		this.a();
	}

	// Token: 0x060067D8 RID: 26584 RVA: 0x002BFB2C File Offset: 0x002BDD2C
	public bi9(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060067D9 RID: 26585 RVA: 0x002BFB3C File Offset: 0x002BDD3C
	public override string g1()
	{
		if (this.a > 0)
		{
			this.a--;
			this.a();
			if (this.a == 0)
			{
				base.a8().RemoveAspect<c5i>();
				base.a8().TileFormationModifiers.s4(1);
				base.a8().z();
			}
			return "rc";
		}
		return null;
	}

	// Token: 0x060067DA RID: 26586 RVA: 0x002BFBA4 File Offset: 0x002BDDA4
	private void a()
	{
		if (base.a8() != null && base.a8().o.b != null)
		{
			base.a8().o.b.b.X = this.a;
		}
	}

	// Token: 0x04002AF2 RID: 10994
	private int a = 3;
}
