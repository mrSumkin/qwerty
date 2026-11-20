using System;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x0200119C RID: 4508
public static class es2
{
	// Token: 0x0600602A RID: 24618 RVA: 0x0029F058 File Offset: 0x0029D258
	public static c5x a(c5x A_0, string A_1, aig[] A_2, bool A_3 = true)
	{
		if (A_0 != null && A_0.Zone != null)
		{
			c5x c5x = es2.a(A_1, A_2);
			if (c5x != null)
			{
				c5x.q(string.Format("Projectile {0} from {1}", c5x.qe(), A_0.y8()));
				Vector3 vector;
				if (A_3)
				{
					vector = es2.a(A_0, 0.8f, true);
				}
				else
				{
					vector = es2.a(A_0, 0f, false);
				}
				c5x.Location = new Vector3(vector.X - c5x.Size.X / 2f, vector.Y - c5x.Size.Y / 2f, vector.Z - c5x.Size.Z / 2f);
				c5x.VisualDirection = A_0.VisualDirection;
				A_0.Area.a(c5x);
			}
			return c5x;
		}
		return null;
	}

	// Token: 0x0600602B RID: 24619 RVA: 0x0029F138 File Offset: 0x0029D338
	public static c5x a(Vector3 A_0, aud A_1, string A_2, aig[] A_3)
	{
		if (A_1 != null)
		{
			c5x c5x = es2.a(A_2, A_3);
			if (c5x != null)
			{
				c5x.q(string.Format("Projectile {0}", c5x.qe()));
				c5x.Location = A_0;
				A_1.a(c5x);
				return c5x;
			}
		}
		return null;
	}

	// Token: 0x0600602C RID: 24620 RVA: 0x0029F188 File Offset: 0x0029D388
	public static c5x a(string A_0, aig[] A_1)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return null;
		}
		c5k c5k = bpo.GetServiceOrThrow<d6j>().dv().a("locale\\projectiles\\" + A_0);
		if (c5k == null)
		{
			return null;
		}
		c5x c5x = c5k.a(null, false) as c5x;
		if (c5x == null)
		{
			return null;
		}
		c5x.Layer = aju.x;
		c5x.Size = new Vector3(1f, 1f, 0.1f);
		c5x.VisualPriority = int.MaxValue;
		if (A_1 != null && A_1.Length != 0)
		{
			b4u aspect = c5x.GetAspect<b4u>();
			if (aspect != null)
			{
				aspect.b().AddRange(A_1);
			}
		}
		return c5x;
	}

	// Token: 0x0600602D RID: 24621 RVA: 0x0029F23C File Offset: 0x0029D43C
	public static dvv a(c5x A_0, b0b A_1, string A_2, float A_3, aig[] A_4, out b0b A_5, bool A_6 = true, float A_7 = 0.5f)
	{
		return es2.a(A_0, A_1, A_2, A_3, out A_5, Vector3.Zero, A_4, A_6, A_7, null);
	}

	// Token: 0x0600602E RID: 24622 RVA: 0x0029F268 File Offset: 0x0029D468
	public static dvv a(c5x A_0, b0b A_1, string A_2, float A_3, out b0b A_4, Vector3 A_5, aig[] A_6, bool A_7 = true, float A_8 = 0.5f, Vector3? A_9 = null)
	{
		A_4 = null;
		if (A_1 != null)
		{
			Vector3 a_ = A_1.aj();
			a_.Z = A_1.Location.Z + A_1.Size.Z * A_3;
			return es2.a(A_0, a_, A_2, out A_4, new Vector3?(A_5), A_6, A_7, A_8, A_9);
		}
		return null;
	}

	// Token: 0x0600602F RID: 24623 RVA: 0x0029F2C4 File Offset: 0x0029D4C4
	public static dvv a(c5x A_0, Vector3 A_1, string A_2, out b0b A_3, Vector3? A_4 = null, aig[] A_5 = null, bool A_6 = true, float A_7 = 0.5f, Vector3? A_8 = null)
	{
		A_3 = null;
		A_3 = es2.a(A_0, A_2, A_5, A_6);
		if (A_3 != null)
		{
			Vector3 vector = new Vector3(A_1.X - A_3.Size.X / 2f, A_1.Y - A_3.Size.Y / 2f, A_1.Z);
			Vector3 vector2 = vector - A_0.Location;
			if (vector2 != Vector3.Zero)
			{
				vector2.Normalize();
				if (A_6)
				{
					A_3.Location += vector2 * A_7;
					A_3.ah();
				}
			}
			if (A_4 != null)
			{
				A_3.Location += A_4.Value;
			}
			if (A_8 != null)
			{
				A_3.Location += A_8.Value;
			}
			A_3.ah();
			A_3.VisualDirection = A_0.VisualDirection;
			if (A_4 != null)
			{
				vector += A_4.Value;
			}
			Vector3 vector3 = vector - A_3.Location;
			if ((Math.Sign(vector3.X) + Math.Sign(vector2.X) == 0 && Math.Sign(vector3.X) != Math.Sign(vector2.X)) || (Math.Sign(vector3.Y) + Math.Sign(vector2.Y) == 0 && Math.Sign(vector3.Y) != Math.Sign(vector2.Y)))
			{
				A_3.Location = vector;
				A_3.ah();
			}
			bpr bpr = new bpr(A_3.GetAspect<mj>(), vector);
			bpr.b(false);
			return bpr;
		}
		return null;
	}

	// Token: 0x06006030 RID: 24624 RVA: 0x0029F48C File Offset: 0x0029D68C
	public static bpr a(Vector3 A_0, Vector3 A_1, aud A_2, string A_3, aig[] A_4, out b0b A_5)
	{
		A_5 = es2.a(A_0, A_2, A_3, A_4);
		if (A_5 != null)
		{
			return new bpr(A_5.GetAspect<mj>(), A_1);
		}
		return null;
	}

	// Token: 0x06006031 RID: 24625 RVA: 0x0029F4B4 File Offset: 0x0029D6B4
	public static Vector3 a(c5x A_0, float A_1 = 0.8f, bool A_2 = true)
	{
		float num = A_0.Location.Z + A_0.Size.Z * A_1;
		Vector3 result;
		if (A_2)
		{
			switch (A_0.VisualDirection)
			{
			case HorizontalDirection.North:
				result = new Vector3(A_0.Location.X + A_0.Size.X / 2f, A_0.Location.Y, num);
				return result;
			case HorizontalDirection.Northeast:
				result = new Vector3(A_0.Location.X + A_0.Size.X, A_0.Location.Y, num);
				return result;
			case HorizontalDirection.East:
				result = new Vector3(A_0.Location.X + A_0.Size.X, A_0.Location.Y + A_0.Size.Y / 2f, num);
				return result;
			case HorizontalDirection.Southeast:
				result = new Vector3(A_0.Location.X + A_0.Size.X, A_0.Location.Y + A_0.Size.Y, num);
				return result;
			case HorizontalDirection.South:
				result = new Vector3(A_0.Location.X + A_0.Size.X / 2f, A_0.Location.Y + A_0.Size.Y, num);
				return result;
			case HorizontalDirection.Southwest:
				result = new Vector3(A_0.Location.X, A_0.Location.Y + A_0.Size.Y, num);
				return result;
			case HorizontalDirection.West:
				result = new Vector3(A_0.Location.X, A_0.Location.Y + A_0.Size.Y / 2f, num);
				return result;
			}
			result = new Vector3(A_0.Location.X, A_0.Location.Y, num);
		}
		else
		{
			result = new Vector3(A_0.Location.X + A_0.Size.X / 2f, A_0.Location.Y + A_0.Size.Y / 2f, num + A_0.Size.Z / 2f);
		}
		return result;
	}
}
