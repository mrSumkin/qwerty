using System;
using System.Runtime.Serialization;

// Token: 0x02001A3F RID: 6719
[eiz("AMSMME")]
[Serializable]
public sealed class dz2 : d3e, ISerializable
{
	// Token: 0x060091BA RID: 37306 RVA: 0x0039D9F4 File Offset: 0x0039BBF4
	private dz2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetSingle("AMSMME:M");
			return;
		}
		if (base.GetType() == typeof(dz2))
		{
			this.a = A_0.GetSingle("_Modifier");
			return;
		}
		this.a = A_0.GetSingle("ApplyMovementSpeedMasterModifierEffect+_Modifier");
	}

	// Token: 0x060091BB RID: 37307 RVA: 0x0039DA64 File Offset: 0x0039BC64
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("AMSMME:M", this.a);
	}

	// Token: 0x060091BC RID: 37308 RVA: 0x0039DA80 File Offset: 0x0039BC80
	public float a()
	{
		return this.a;
	}

	// Token: 0x060091BD RID: 37309 RVA: 0x0039DA88 File Offset: 0x0039BC88
	public void a(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060091BE RID: 37310 RVA: 0x0039DA94 File Offset: 0x0039BC94
	public dz2()
	{
		base.Priority = 2147483646;
	}

	// Token: 0x060091BF RID: 37311 RVA: 0x0039DAA8 File Offset: 0x0039BCA8
	public dz2(float A_0)
	{
		base.Priority = 2147483646;
		this.a = A_0;
	}

	// Token: 0x060091C0 RID: 37312 RVA: 0x0039DAC4 File Offset: 0x0039BCC4
	public override d3e b3()
	{
		dz2 dz = new dz2();
		this.xx(dz);
		return dz;
	}

	// Token: 0x060091C1 RID: 37313 RVA: 0x0039DAE0 File Offset: 0x0039BCE0
	protected override void @in(ll A_0)
	{
		if ((A_0.a().MovementSpeed *= this.a) < aiy.e)
		{
			A_0.a().MovementSpeed = aiy.e;
		}
	}

	// Token: 0x060091C2 RID: 37314 RVA: 0x0039DB24 File Offset: 0x0039BD24
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((dz2)A_0).a = this.a;
	}

	// Token: 0x04003838 RID: 14392
	private new float a;
}
