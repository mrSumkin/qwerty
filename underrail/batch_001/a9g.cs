using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02001326 RID: 4902
[eiz("WEA")]
[a(typeof(cd0))]
[Serializable]
public sealed class a9g : cd0, brq, ISerializable
{
	// Token: 0x06006F13 RID: 28435 RVA: 0x002EA9B4 File Offset: 0x002E8BB4
	private a9g(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006F14 RID: 28436 RVA: 0x002EA9C0 File Offset: 0x002E8BC0
	public a9g(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006F15 RID: 28437 RVA: 0x002EA9CC File Offset: 0x002E8BCC
	public string v1()
	{
		return this.a;
	}

	// Token: 0x06006F16 RID: 28438 RVA: 0x002EA9D8 File Offset: 0x002E8BD8
	public override void v2()
	{
		int num = this.b.Y * 6 + this.b.X;
		if (++num > 17)
		{
			num = 0;
		}
		this.b = new Point(num % 6, (num > 5) ? ((num > 11) ? 2 : 1) : 0);
	}

	// Token: 0x06006F17 RID: 28439 RVA: 0x002EAA38 File Offset: 0x002E8C38
	public override void v3()
	{
		int num = this.b.Y * 6 + this.b.X;
		if (--num < 0)
		{
			num = 17;
		}
		this.b = new Point(num % 6, (num > 5) ? ((num > 11) ? 2 : 1) : 0);
	}

	// Token: 0x06006F18 RID: 28440 RVA: 0x002EAA98 File Offset: 0x002E8C98
	public void v4(bool A_0)
	{
		string a_ = A_0 ? this.v1() : null;
		List<HorizontalDirection> list = new List<HorizontalDirection>();
		if (a9g.a(base.a8().Area, (int)base.a8().Location.X, (int)base.a8().Location.Y - 1, a_))
		{
			list.Add(HorizontalDirection.North);
		}
		if (a9g.a(base.a8().Area, (int)base.a8().Location.X, (int)base.a8().Location.Y + 1, a_))
		{
			list.Add(HorizontalDirection.South);
		}
		if (a9g.a(base.a8().Area, (int)base.a8().Location.X - 1, (int)base.a8().Location.Y, a_))
		{
			list.Add(HorizontalDirection.West);
		}
		if (a9g.a(base.a8().Area, (int)base.a8().Location.X + 1, (int)base.a8().Location.Y, a_))
		{
			list.Add(HorizontalDirection.East);
		}
		if (list.Count == 0)
		{
			this.b = new Point(0, 0);
			return;
		}
		if (list.Contains(HorizontalDirection.West))
		{
			if (list.Contains(HorizontalDirection.East))
			{
				if (list.Contains(HorizontalDirection.North))
				{
					if (list.Contains(HorizontalDirection.South))
					{
						this.b = new Point(5, 1);
						return;
					}
					this.b = new Point(3, 1);
					return;
				}
				else
				{
					if (list.Contains(HorizontalDirection.South))
					{
						this.b = new Point(4, 1);
						return;
					}
					this.b = new Point(1, 0);
					return;
				}
			}
			else if (list.Contains(HorizontalDirection.North))
			{
				if (list.Contains(HorizontalDirection.South))
				{
					this.b = new Point(2, 1);
					return;
				}
				this.b = new Point(0, 1);
				return;
			}
			else
			{
				if (list.Contains(HorizontalDirection.South))
				{
					this.b = new Point(4, 0);
					return;
				}
				this.b = new Point(1, 0);
				return;
			}
		}
		else if (list.Contains(HorizontalDirection.East))
		{
			if (list.Contains(HorizontalDirection.North))
			{
				if (list.Contains(HorizontalDirection.South))
				{
					this.b = new Point(1, 1);
					return;
				}
				this.b = new Point(5, 0);
				return;
			}
			else
			{
				if (list.Contains(HorizontalDirection.South))
				{
					this.b = new Point(3, 0);
					return;
				}
				this.b = new Point(1, 0);
				return;
			}
		}
		else
		{
			if (!list.Contains(HorizontalDirection.North))
			{
				this.b = new Point(2, 0);
				return;
			}
			if (list.Contains(HorizontalDirection.South))
			{
				this.b = new Point(2, 0);
				return;
			}
			this.b = new Point(2, 0);
			return;
		}
	}

	// Token: 0x06006F19 RID: 28441 RVA: 0x002EAD54 File Offset: 0x002E8F54
	private new static bool a(aud A_0, int A_1, int A_2, string A_3)
	{
		if (A_1 >= 0 && A_2 >= 0 && A_1 < A_0.Size.c && A_2 < A_0.Size.d)
		{
			foreach (b0b b0b in A_0[A_1, A_2].Entities)
			{
				brq brq = Enumerable.FirstOrDefault<brq>(Enumerable.OfType<brq>(b0b.Aspects));
				if (brq != null && (A_3 == null || A_3 == brq.AutoWallCategory))
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}
}
