using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001094 RID: 4244
[eiz("PTTKJ")]
[Serializable]
public sealed class z7 : cze, ISerializable
{
	// Token: 0x060058DD RID: 22749 RVA: 0x00268144 File Offset: 0x00266344
	private z7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("PTTKJ:R");
		if (ell.a() >= 505)
		{
			this.b = A_0.GetString("PTTKJ:F");
		}
	}

	// Token: 0x060058DE RID: 22750 RVA: 0x00268194 File Offset: 0x00266394
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PTTKJ:R", this.a);
		info.AddValue("PTTKJ:F", this.b);
	}

	// Token: 0x170001BB RID: 443
	// (get) Token: 0x060058DF RID: 22751 RVA: 0x002681C0 File Offset: 0x002663C0
	public int RemainingTicks
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x170001BC RID: 444
	// (get) Token: 0x060058E0 RID: 22752 RVA: 0x002681C8 File Offset: 0x002663C8
	// (set) Token: 0x060058E1 RID: 22753 RVA: 0x002681D0 File Offset: 0x002663D0
	public string ActivatorFactionId
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x060058E2 RID: 22754 RVA: 0x002681DC File Offset: 0x002663DC
	public z7()
	{
	}

	// Token: 0x060058E3 RID: 22755 RVA: 0x002681F0 File Offset: 0x002663F0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && A_2 != null)
		{
			object obj;
			A_2.TryGetValue("tickCount", out obj);
			if (obj is int)
			{
				int num = this.a - 1;
				this.a = num;
				if (num <= 0)
				{
					boj.a(c5x, "Xpbl_PropaneTankExplosion", 1, double.MaxValue, false, false, null, null, null, null, false);
					dm5 dm = new dm5();
					dm.a(this.b);
					dm.d(c5x.y8());
					dm.a(3);
					dm.d(true);
					dm.s().Add(new a1q(DamageType.Heat, 100, 150));
					dm.s().Add(new a1q(DamageType.Mechanical, 75, 125));
					dm.ym(null, c5x, null);
					dm.a(new AmmoType?(AmmoType.HighExplosives));
					dm.a(0.1);
					dm.c(true);
					c5x.w();
					c5x.an();
					return;
				}
				bmj.a(c5x, new efj(this.a));
			}
		}
	}

	// Token: 0x040023C5 RID: 9157
	private new int a = 10;

	// Token: 0x040023C6 RID: 9158
	private string b;
}
