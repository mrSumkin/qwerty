using System;
using System.Runtime.Serialization;

// Token: 0x02001292 RID: 4754
[a(typeof(c5i))]
[eiz("TCRPEA")]
[Serializable]
public sealed class w7 : c5i, ISerializable
{
	// Token: 0x060067CD RID: 26573 RVA: 0x002BF9A0 File Offset: 0x002BDBA0
	private w7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("TCRPEA:R");
	}

	// Token: 0x060067CE RID: 26574 RVA: 0x002BF9C4 File Offset: 0x002BDBC4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TCRPEA:R", this.a);
	}

	// Token: 0x060067CF RID: 26575 RVA: 0x002BF9E0 File Offset: 0x002BDBE0
	public int b()
	{
		return this.a;
	}

	// Token: 0x060067D0 RID: 26576 RVA: 0x002BF9E8 File Offset: 0x002BDBE8
	public void a(int A_0)
	{
		this.a = d05.a(1, A_0, 3);
		this.a();
	}

	// Token: 0x060067D1 RID: 26577 RVA: 0x002BFA00 File Offset: 0x002BDC00
	public w7(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060067D2 RID: 26578 RVA: 0x002BFA14 File Offset: 0x002BDC14
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
			return "crc";
		}
		return null;
	}

	// Token: 0x060067D3 RID: 26579 RVA: 0x002BFA7C File Offset: 0x002BDC7C
	private void a()
	{
		if (base.a8() != null && base.a8().o.b != null)
		{
			base.a8().o.b.b.X = this.a;
		}
	}

	// Token: 0x04002AF1 RID: 10993
	private int a = 3;
}
