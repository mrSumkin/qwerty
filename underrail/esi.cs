using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A7D RID: 2685
[eiz("SWASJ")]
[Serializable]
public sealed class esi : cze, ISerializable
{
	// Token: 0x06003F33 RID: 16179 RVA: 0x0017EAB8 File Offset: 0x0017CCB8
	private esi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("SWASJ:L");
	}

	// Token: 0x06003F34 RID: 16180 RVA: 0x0017EAD4 File Offset: 0x0017CCD4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SWASJ:L", this.a);
	}

	// Token: 0x06003F35 RID: 16181 RVA: 0x0017EAF0 File Offset: 0x0017CCF0
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06003F36 RID: 16182 RVA: 0x0017EAF8 File Offset: 0x0017CCF8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003F37 RID: 16183 RVA: 0x0017EB04 File Offset: 0x0017CD04
	public esi()
	{
	}

	// Token: 0x06003F38 RID: 16184 RVA: 0x0017EB10 File Offset: 0x0017CD10
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_0.Area != null)
		{
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null)
			{
				foreach (b45 a_ in aspect.aa().StatusEffects.Get<b45>())
				{
					aspect.aa().StatusEffects.d(a_);
				}
				if (this.a)
				{
					bool flag = new ar7(new Guid("08845eeb-d059-4454-8404-fd7682658055"), A_0.Area).ao() is c5x;
					c5x c5x = new ar7(new Guid("770076bc-bcb6-4d4d-9706-3308ca67d2fb"), A_0.Area).ao() as c5x;
					c5x c5x2 = new ar7(new Guid("6050a904-839f-4cc3-b133-9e8a5ec219ad"), A_0.Area).ao() as c5x;
					c5x c5x3 = new ar7(new Guid("6050a904-839f-4cc3-b133-9e8a5ec219ad"), A_0.Area).ao() as c5x;
					c5x c5x4 = new ar7(new Guid("9f341004-232c-484a-a8ae-660882a5f8e3"), A_0.Area).ao() as c5x;
					if (flag)
					{
						aspect.aa().StatusEffects.a(new b45("Mechanics"), false, false, false);
					}
					if (c5x != null)
					{
						aspect.aa().StatusEffects.a(new b45("Electronics"), false, false, false);
					}
					if (c5x2 != null)
					{
						aspect.aa().StatusEffects.a(new b45("Chemistry"), false, false, false);
					}
					if (c5x3 != null)
					{
						aspect.aa().StatusEffects.a(new b45("Biology"), false, false, false);
					}
					if (c5x4 != null)
					{
						aspect.aa().StatusEffects.a(new b45("Tailoring"), false, false, false);
					}
				}
			}
		}
	}

	// Token: 0x04001BD4 RID: 7124
	private new bool a;
}
