using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001146 RID: 4422
[eiz("JSRJT")]
[Serializable]
public sealed class bo9 : ya, ISerializable
{
	// Token: 0x06005EBA RID: 24250 RVA: 0x00281BB4 File Offset: 0x0027FDB4
	private bo9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (HorizontalDirection)A_0.GetValue("JSRJT:D", typeof(HorizontalDirection));
		this.c = A_0.GetSingle("JSRJT:M");
		this.b = A_0.GetSingle("JSRJT:X");
	}

	// Token: 0x06005EBB RID: 24251 RVA: 0x00281C0C File Offset: 0x0027FE0C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("JSRJT:D", this.a);
		info.AddValue("JSRJT:M", this.c);
		info.AddValue("JSRJT:X", this.b);
	}

	// Token: 0x06005EBC RID: 24252 RVA: 0x00281C5C File Offset: 0x0027FE5C
	public HorizontalDirection a()
	{
		return this.a;
	}

	// Token: 0x06005EBD RID: 24253 RVA: 0x00281C64 File Offset: 0x0027FE64
	public void a(HorizontalDirection A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005EBE RID: 24254 RVA: 0x00281C70 File Offset: 0x0027FE70
	public float b()
	{
		return this.c;
	}

	// Token: 0x06005EBF RID: 24255 RVA: 0x00281C78 File Offset: 0x0027FE78
	public void b(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005EC0 RID: 24256 RVA: 0x00281C84 File Offset: 0x0027FE84
	public float c()
	{
		return this.b;
	}

	// Token: 0x06005EC1 RID: 24257 RVA: 0x00281C8C File Offset: 0x0027FE8C
	public void a(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005EC2 RID: 24258 RVA: 0x00281C98 File Offset: 0x0027FE98
	public bo9()
	{
	}

	// Token: 0x06005EC3 RID: 24259 RVA: 0x00281CA0 File Offset: 0x0027FEA0
	public bool a(amc A_0, out float A_1)
	{
		A_1 = 0f;
		if (A_0 != null && A_0.aa().Vehicle != null)
		{
			A_1 = Convert.ToSingle(A_0.aa().Vehicle.m() * 4.0);
			return A_0.aa().Vehicle.j()[DamageType.Mechanical].c() < 0.5 && A_1 + 1f >= this.c;
		}
		return false;
	}

	// Token: 0x06005EC4 RID: 24260 RVA: 0x00281D30 File Offset: 0x0027FF30
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null)
		{
			amc aspect = c5x.GetAspect<amc>();
			if (aspect != null && aspect.aa() is e3q && aspect.aa().Vehicle != null && c5x.i.b != null && bnx.a(A_0.aj(), base.Location.a() + new Vector3(0.5f, 0.5f, 0f)) == this.a)
			{
				ar7 classPropertyValue = c5x.d().a().GetClassPropertyValue<ar7>(bah.c);
				if (classPropertyValue != null && classPropertyValue.ao() != null)
				{
					bmj.a(c5x, new d53("Нельзя прыгать на рампе во время буксировки.", adi.m, null, false));
					return;
				}
				float num;
				if (this.a(aspect, out num))
				{
					num = MathHelper.Clamp(num, this.c, this.b);
					awx awx = new awx("rampJump");
					awx.a(m7.b | m7.k | m7.o);
					awx.a(false);
					e8s item = new e8s(A_0 as c5x, num, this.a);
					awx.ad().Add(item);
					c5x.i.b.b(awx, atp.a);
					dz6.a(awx);
					return;
				}
				bmj.a(c5x, new d53("Слишком медленно!", adi.m, null, false));
			}
		}
	}

	// Token: 0x0400259F RID: 9631
	private HorizontalDirection a;

	// Token: 0x040025A0 RID: 9632
	private float b;

	// Token: 0x040025A1 RID: 9633
	private float c;
}
