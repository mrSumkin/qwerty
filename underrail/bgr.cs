using System;
using System.Runtime.Serialization;

// Token: 0x02001A55 RID: 6741
[eiz("MQSNE")]
[Serializable]
public sealed class bgr : d3e, ISerializable
{
	// Token: 0x06009251 RID: 37457 RVA: 0x0039F164 File Offset: 0x0039D364
	private bgr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetInt32("MQSNE:NOS");
			return;
		}
		if (base.GetType() == typeof(bgr))
		{
			this.a = A_0.GetInt32("_NumberOfSlots");
			return;
		}
		this.a = A_0.GetInt32("ModifyQuickSlotsNumberEffect+_NumberOfSlots");
	}

	// Token: 0x06009252 RID: 37458 RVA: 0x0039F1D4 File Offset: 0x0039D3D4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MQSNE:NOS", this.a);
	}

	// Token: 0x06009253 RID: 37459 RVA: 0x0039F1F0 File Offset: 0x0039D3F0
	public int a()
	{
		return this.a;
	}

	// Token: 0x06009254 RID: 37460 RVA: 0x0039F1F8 File Offset: 0x0039D3F8
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009255 RID: 37461 RVA: 0x0039F204 File Offset: 0x0039D404
	public bgr()
	{
	}

	// Token: 0x06009256 RID: 37462 RVA: 0x0039F20C File Offset: 0x0039D40C
	public bgr(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009257 RID: 37463 RVA: 0x0039F21C File Offset: 0x0039D41C
	protected override void @in(ll A_0)
	{
		A_0.a().AvailableQuickSlots += this.a;
	}

	// Token: 0x06009258 RID: 37464 RVA: 0x0039F238 File Offset: 0x0039D438
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((bgr)A_0).a = this.a;
	}

	// Token: 0x06009259 RID: 37465 RVA: 0x0039F258 File Offset: 0x0039D458
	public override string b2()
	{
		int num = Math.Abs(this.a);
		if (num == 1)
		{
			if (this.a >= 0)
			{
				return qv.b("StaticEffects/ModifyQuickSlotsNumber_IncreasedSingle");
			}
			return qv.b("StaticEffects/ModifyQuickSlotsNumber_DecreasedSingle");
		}
		else
		{
			if (this.a >= 0)
			{
				return qv.a("StaticEffects/ModifyQuickSlotsNumber_Increased", new object[]
				{
					num
				});
			}
			return qv.a("StaticEffects/ModifyQuickSlotsNumber_Decreased", new object[]
			{
				num
			});
		}
	}

	// Token: 0x0600925A RID: 37466 RVA: 0x0039F2DC File Offset: 0x0039D4DC
	public override d3e b3()
	{
		bgr bgr = new bgr();
		this.xx(bgr);
		return bgr;
	}

	// Token: 0x0400384B RID: 14411
	private new int a;
}
