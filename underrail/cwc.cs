using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Rules;

// Token: 0x02000F88 RID: 3976
[eiz("SGEAX")]
[Serializable]
public sealed class cwc : Aspect<c5x>, cmm
{
	// Token: 0x060050F6 RID: 20726 RVA: 0x00247158 File Offset: 0x00245358
	private cwc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("SGEAX:T");
	}

	// Token: 0x060050F7 RID: 20727 RVA: 0x00247174 File Offset: 0x00245374
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SGEAX:T", this.b);
	}

	// Token: 0x060050F8 RID: 20728 RVA: 0x00247190 File Offset: 0x00245390
	public cwc(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060050F9 RID: 20729 RVA: 0x0024719C File Offset: 0x0024539C
	public void c9(TimeSpan A_0)
	{
		this.b += A_0.TotalMinutes;
		this.a();
	}

	// Token: 0x060050FA RID: 20730 RVA: 0x002471B8 File Offset: 0x002453B8
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x060050FB RID: 20731 RVA: 0x002471BC File Offset: 0x002453BC
	public void r7(eds A_0)
	{
	}

	// Token: 0x060050FC RID: 20732 RVA: 0x002471C4 File Offset: 0x002453C4
	private void a()
	{
		if (this.b >= (double)cwc.a)
		{
			string[] array = new string[]
			{
				"object\\natural\\ShroomlingChomper-Static",
				"object\\natural\\ShroomlingSpitter-Static"
			};
			HashSet<Vector3> hashSet = new HashSet<Vector3>();
			foreach (b0b b0b in base.a8().Area.Entities)
			{
				c5x c5x = (c5x)b0b;
				bool aspect = c5x.GetAspect<amc>() != null;
				bm6 aspect2 = c5x.GetAspect<bm6>();
				if (aspect && aspect2 != null)
				{
					bt4 classPropertyValue = aspect2.y6().GetClassPropertyValue<bt4>("SleepLoc");
					if (classPropertyValue != null)
					{
						aud aud;
						Vector3 vector;
						classPropertyValue.a(c5x.Zone, out aud, out vector);
						hashSet.Add(vector);
					}
				}
				else
				{
					aoq aspect3 = c5x.GetAspect<aoq>();
					if (aspect3 != null)
					{
						hashSet.Add(aspect3.a8().Location);
					}
				}
			}
			List<csd> list = new List<csd>();
			List<csd> list2 = new List<csd>();
			bu6 serviceOrThrow = bpo.GetServiceOrThrow<bu6>();
			using (IEnumerator<csd> enumerator2 = base.a8().Area.Zone.Waypoints.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					csd csd = enumerator2.Current;
					if (csd.Name != null && !hashSet.Contains(csd.Location) && (csd.Name.StartsWith("shroom_", StringComparison.OrdinalIgnoreCase) || (serviceOrThrow.aq2() >= GameDifficulty.Hard && csd.Name.StartsWith("shroomHard_", StringComparison.OrdinalIgnoreCase)) || (serviceOrThrow.aq2() >= GameDifficulty.Dominating && csd.Name.StartsWith("shroomDom_", StringComparison.OrdinalIgnoreCase))))
					{
						list.Add(csd);
						ak1 ak = base.a8().Area.a(csd.Location.a());
						if (ak != null && !aw1.a(null, ak, false, null))
						{
							list2.Add(csd);
						}
					}
				}
				goto IL_2F3;
			}
			IL_20C:
			this.b -= (double)cwc.a;
			csd csd2 = list2[cuo.a.Next(list2.Count)];
			aud aud2 = base.a8().Zone.n(csd2.AreaName);
			if (aud2 != null)
			{
				c5x c5x2 = vq.a(array[cuo.a.Next(array.Length)], false);
				if (c5x2 != null)
				{
					c5x2.Layer = aju.x;
					c5x2.Location = csd2.Location;
					c5x2.VisualDirection = csd2.Direction;
					dtb dtb = new dtb();
					dtb.ad().Add(new a4s(new bk6(aud2, c5x2), null, null, null));
					base.a8().Zone.ActionManager.g9(dtb, atp.a);
					list2.Remove(csd2);
					list.Remove(csd2);
				}
			}
			IL_2F3:
			if (this.b >= (double)cwc.a && list2.Count > 0)
			{
				goto IL_20C;
			}
			this.b = Math.Min(this.b, (double)(list.Count * cwc.a));
		}
	}

	// Token: 0x0400212E RID: 8494
	private static readonly int a = 10;

	// Token: 0x0400212F RID: 8495
	private double b;
}
