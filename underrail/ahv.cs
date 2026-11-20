using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x0200148E RID: 5262
[eiz("DFRA")]
[Serializable]
public sealed class ahv : a6k, ISerializable
{
	// Token: 0x06007696 RID: 30358 RVA: 0x00322E44 File Offset: 0x00321044
	private ahv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007697 RID: 30359 RVA: 0x00322E50 File Offset: 0x00321050
	public ahv()
	{
	}

	// Token: 0x06007698 RID: 30360 RVA: 0x00322E5C File Offset: 0x0032105C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ahv.a a = new ahv.a();
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null || base.vg().q() == null || aw1.a(ak, false, null, l9.a))
		{
			return dc4.e;
		}
		a.a = this.a(ak);
		if (this.b(ak, a.a, 1) || this.b(ak, a.a, 2))
		{
			base.vg().e().a(true);
			base.vg().q().c().a(Guid.NewGuid().ToString(), "FishingRodDeploy", 1f, c9z.a, false, false);
			return dc4.c;
		}
		List<HorizontalDirection> list = new List<HorizontalDirection>();
		list.Add(HorizontalDirection.North);
		list.Add(HorizontalDirection.South);
		list.Add(HorizontalDirection.East);
		list.Add(HorizontalDirection.West);
		Func<HorizontalDirection, bool> func;
		if ((func = a.b) == null)
		{
			func = (a.b = new Func<HorizontalDirection, bool>(a.a));
		}
		foreach (HorizontalDirection a_ in Enumerable.Where<HorizontalDirection>(list, func))
		{
			if (this.b(ak, a_, 1) || this.b(ak, a_, 2))
			{
				base.vg().e().a(true);
				base.vg().q().c().a(Guid.NewGuid().ToString(), "FishingRodDeploy", 1f, c9z.a, false, false);
				return dc4.c;
			}
		}
		string a_2 = qv.b("Items\\Utilities/FishingRodMountingFailed");
		a7v.a(new h0(a_2, new Color?(adi.l)));
		bmj.a(base.vg().q(), new d53(a_2, adi.l, null, false));
		return dc4.e;
	}

	// Token: 0x06007699 RID: 30361 RVA: 0x00323068 File Offset: 0x00321268
	private bool b(ak1 A_0, HorizontalDirection A_1, int A_2)
	{
		ak1 ak = ahv.a(A_0, A_1, A_2);
		if (ak == null)
		{
			return false;
		}
		if (ahv.a(ak, A_1))
		{
			d6j serviceOrThrow = bpo.GetServiceOrThrow<d6j>();
			c5k c5k;
			if (A_2 > 1)
			{
				c5k = serviceOrThrow.dv().a("Locale\\Object\\Items\\FishingRod_Long_" + A_1.ToString()[0].ToString());
			}
			else
			{
				c5k = serviceOrThrow.dv().a("Locale\\Object\\Items\\FishingRod_" + A_1.ToString()[0].ToString());
			}
			if (c5k != null)
			{
				b0b b0b = c5k.a(null, false);
				b0b.Layer = aju.x;
				b0b.Location = new Vector3((float)Math.Min(A_0.Location.X, ak.Location.X), (float)Math.Min(A_0.Location.Y, ak.Location.Y), 0f);
				Point point;
				Point point2;
				b0b.a(A_0.Playfield, out point, out point2);
				for (int i = point.X; i <= point2.X; i++)
				{
					for (int j = point.Y; j <= point2.Y; j++)
					{
						ak1 ak2 = A_0.Area.b(i, j);
						if (ak2 != null)
						{
							using (IEnumerator<b0b> enumerator = ak2.Entities.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									if ((c5x)enumerator.Current == base.vg().q())
									{
										return false;
									}
								}
							}
						}
					}
				}
				A_0.Area.a(b0b);
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600769A RID: 30362 RVA: 0x00323258 File Offset: 0x00321458
	private static bool a(ak1 A_0, HorizontalDirection A_1)
	{
		if (aw1.a(null, A_0, false, null))
		{
			bool result = false;
			byte a_ = ahv.a(A_1);
			foreach (b0b b0b in A_0.Entities)
			{
				c5x c5x = (c5x)b0b;
				if (c5x.o != null && c5x.o.b != null)
				{
					if (string.Equals(c5x.o.b.a, "Floor\\Water", StringComparison.OrdinalIgnoreCase) || string.Equals(c5x.o.b.a, "Floor\\DirtyWater", StringComparison.OrdinalIgnoreCase) || string.Equals(c5x.o.b.a, "Floor\\DeepWater", StringComparison.OrdinalIgnoreCase))
					{
						result = true;
						continue;
					}
					if (c5x.IsFloor && (string.Equals(c5x.o.b.a, "Floor\\CaveOW", StringComparison.OrdinalIgnoreCase) || string.Equals(c5x.o.b.a, "Floor\\CaveOWR", StringComparison.OrdinalIgnoreCase)))
					{
						if (ahv.a(c5x.o.b, a_))
						{
							return false;
						}
						continue;
					}
					else if (c5x.TileFormationModifiers.c(2L) && (c5x.Size.X >= 2f || c5x.Size.Y >= 2f))
					{
						return false;
					}
				}
				if (!c5x.IsFloor && c5x.GetAspect<dha>() == null && c5x.GetAspect<b4u>() == null)
				{
					return false;
				}
			}
			return result;
		}
		return false;
	}

	// Token: 0x0600769B RID: 30363 RVA: 0x00323430 File Offset: 0x00321630
	private static bool a(cd0 A_0, byte A_1)
	{
		if (A_0.b == Point.Zero)
		{
			return true;
		}
		bzx bzx = eum.a(A_0.b);
		return bzx == null || (bzx.b & A_1) > 0;
	}

	// Token: 0x0600769C RID: 30364 RVA: 0x00323474 File Offset: 0x00321674
	private static byte a(HorizontalDirection A_0)
	{
		switch (A_0)
		{
		case HorizontalDirection.North:
		case HorizontalDirection.West:
			return ahv.a(7);
		case HorizontalDirection.South:
			return ahv.a(2);
		}
		return ahv.a(5);
	}

	// Token: 0x0600769D RID: 30365 RVA: 0x003234B4 File Offset: 0x003216B4
	private static byte a(int A_0)
	{
		return (byte)(1 << A_0);
	}

	// Token: 0x0600769E RID: 30366 RVA: 0x003234C0 File Offset: 0x003216C0
	private static ak1 a(ak1 A_0, HorizontalDirection A_1, int A_2 = 1)
	{
		Point a_ = A_0.Location;
		switch (A_1)
		{
		case HorizontalDirection.North:
			a_.Y -= A_2;
			break;
		case HorizontalDirection.East:
			a_.X += A_2;
			break;
		case HorizontalDirection.South:
			a_.Y += A_2;
			break;
		case HorizontalDirection.West:
			a_.X -= A_2;
			break;
		}
		return A_0.Area.a(a_);
	}

	// Token: 0x0600769F RID: 30367 RVA: 0x00323548 File Offset: 0x00321748
	private HorizontalDirection a(ak1 A_0)
	{
		Point point = base.vg().q().aj().a();
		int num = A_0.Location.X - point.X;
		int num2 = A_0.Location.Y - point.Y;
		if (Math.Abs(num) > Math.Abs(num2))
		{
			if (num > 0)
			{
				return HorizontalDirection.East;
			}
			return HorizontalDirection.West;
		}
		else
		{
			if (num2 > 0)
			{
				return HorizontalDirection.South;
			}
			return HorizontalDirection.North;
		}
	}

	// Token: 0x0200148F RID: 5263
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060076A1 RID: 30369 RVA: 0x003235C0 File Offset: 0x003217C0
		internal bool a(HorizontalDirection A_0)
		{
			return A_0 != this.a;
		}

		// Token: 0x04003045 RID: 12357
		public HorizontalDirection a;

		// Token: 0x04003046 RID: 12358
		public Func<HorizontalDirection, bool> b;
	}
}
