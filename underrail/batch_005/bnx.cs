using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;
using Ouroboros.Playfield.Space;

// Token: 0x02000251 RID: 593
public static class bnx
{
	// Token: 0x060010FF RID: 4351 RVA: 0x00046098 File Offset: 0x00044298
	public static Dictionary<Point, e23> a(etb A_0, Vector3 A_1, Vector3 A_2)
	{
		czh.a(A_0, "schema");
		Dictionary<Point, e23> dictionary = new Dictionary<Point, e23>();
		int num = (int)(A_1.Y + A_0.a().b());
		int num2 = (int)(A_1.X + A_0.a().b());
		int num3 = (int)(A_1.Y + A_2.Y - (A_0.a().b() + 1E-05f));
		int num4 = (int)(A_1.X + A_2.X - (A_0.a().b() + 1E-05f));
		for (int i = num; i <= num3; i++)
		{
			for (int j = num2; j <= num4; j++)
			{
				dictionary.Add(new Point(j, i), e23.a);
			}
		}
		return dictionary;
	}

	// Token: 0x06001100 RID: 4352 RVA: 0x00046158 File Offset: 0x00044358
	public static List<ak1> a(aud A_0, Point A_1, esj A_2)
	{
		List<ak1> list = new List<ak1>();
		int num = A_1.Y;
		while (num < A_1.Y + A_2.d && num < A_0.Size.d)
		{
			int num2 = A_1.X;
			while (num2 < A_1.X + A_2.c && num2 < A_0.Size.c)
			{
				list.Add(A_0.b(num2, num));
				num2++;
			}
			num++;
		}
		return list;
	}

	// Token: 0x06001101 RID: 4353 RVA: 0x000461DC File Offset: 0x000443DC
	public static CollectionDelta<ak1> a(b0b A_0, etb A_1, aud A_2, ICollection<ak1> A_3, Vector3 A_4, Vector3 A_5)
	{
		List<ak1> list = new List<ak1>();
		if (A_0 != null && A_0.j != cgy.a && A_1 != null && A_2 != null)
		{
			foreach (KeyValuePair<Point, e23> keyValuePair in bnx.a(A_1, A_4, A_5))
			{
				Point key = keyValuePair.Key;
				e23 value = keyValuePair.Value;
				ak1 ak = A_2.b(key.X, key.Y);
				if (ak != null && value == e23.a)
				{
					list.Add(ak);
				}
			}
		}
		return jw.GetDelta<ak1>(A_3, list);
	}

	// Token: 0x06001102 RID: 4354 RVA: 0x00046298 File Offset: 0x00044498
	public static HorizontalDirection a(Vector3 A_0, Vector3 A_1)
	{
		Vector3 a_ = A_1 - A_0;
		a_.Normalize();
		return bnx.a(a_);
	}

	// Token: 0x06001103 RID: 4355 RVA: 0x000462BC File Offset: 0x000444BC
	public static HorizontalDirection a(Vector3 A_0)
	{
		if (A_0.X != 0f || A_0.Y != 0f)
		{
			float num = Math.Abs(A_0.X) / (Math.Abs(A_0.X) + Math.Abs(A_0.Y));
			if (num > 0.66f)
			{
				if (A_0.X < 0f)
				{
					return HorizontalDirection.West;
				}
				return HorizontalDirection.East;
			}
			else if (num < 0.33f)
			{
				if (A_0.Y < 0f)
				{
					return HorizontalDirection.North;
				}
				return HorizontalDirection.South;
			}
			else if (A_0.X > 0f)
			{
				if (A_0.Y > 0f)
				{
					return HorizontalDirection.Southeast;
				}
				return HorizontalDirection.Northeast;
			}
			else if (A_0.X < 0f)
			{
				if (A_0.Y > 0f)
				{
					return HorizontalDirection.Southwest;
				}
				return HorizontalDirection.Northwest;
			}
		}
		return HorizontalDirection.Southeast;
	}

	// Token: 0x06001104 RID: 4356 RVA: 0x00046394 File Offset: 0x00044594
	public static float a(Point A_0, Point A_1)
	{
		return (float)Math.Sqrt(Math.Pow((double)(A_1.X - A_0.X), 2.0) + Math.Pow((double)(A_1.Y - A_0.Y), 2.0));
	}

	// Token: 0x06001105 RID: 4357 RVA: 0x000463E0 File Offset: 0x000445E0
	public static float a(Point A_0, b0b A_1)
	{
		Point point;
		Point point2;
		A_1.a(out point, out point2);
		int x = d05.a(point.X, A_0.X, point2.X);
		int y = d05.a(point.Y, A_0.Y, point2.Y);
		return bnx.a(A_0, new Point(x, y));
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x00046434 File Offset: 0x00044634
	public static List<ejt> a(b0b A_0, string A_1)
	{
		List<ejt> list = new List<ejt>();
		if (A_0 != null && A_1 != null && A_0.RaysEmitters.Count > 0)
		{
			foreach (ejt ejt in A_0.RaysEmitters)
			{
				a9q a9q = ejt.SourceDefinition as a9q;
				if (a9q != null && a9q.y8() != null && A_1.Equals(a9q.y8()))
				{
					list.Add(ejt);
				}
			}
		}
		return list;
	}

	// Token: 0x06001107 RID: 4359 RVA: 0x000464E0 File Offset: 0x000446E0
	public static double a(Vector2 A_0, HorizontalDirection A_1, Vector2 A_2)
	{
		Vector3 vector = bnx.b(A_1).b();
		Vector3 vector2 = (A_2 - A_0).b();
		vector.Normalize();
		vector2.Normalize();
		return Math.Acos((double)d05.b(-1f, Vector3.Dot(vector, vector2), 1f)) * 180.0 / 3.141592653589793;
	}

	// Token: 0x06001108 RID: 4360 RVA: 0x00046544 File Offset: 0x00044744
	public static double a(Vector2 A_0, Vector2 A_1, Vector2 A_2)
	{
		Vector3 vector = (A_1 - A_0).b();
		Vector3 vector2 = (A_2 - A_0).b();
		vector.Normalize();
		vector2.Normalize();
		if (vector == Vector3.Zero || vector2 == Vector3.Zero)
		{
			return 0.0;
		}
		return Math.Acos((double)d05.b(-1f, Vector3.Dot(vector, vector2), 1f)) * 180.0 / 3.141592653589793;
	}

	// Token: 0x06001109 RID: 4361 RVA: 0x000465D4 File Offset: 0x000447D4
	public static Vector2 b(HorizontalDirection A_0)
	{
		Vector2 result = default(Vector2);
		if (A_0 == HorizontalDirection.North || A_0 == HorizontalDirection.Northeast || A_0 == HorizontalDirection.Northwest)
		{
			result.Y -= 1f;
		}
		else if (A_0 >= HorizontalDirection.Southeast && A_0 <= HorizontalDirection.Southwest)
		{
			result.Y += 1f;
		}
		if (A_0 >= HorizontalDirection.Northeast && A_0 <= HorizontalDirection.Southeast)
		{
			result.X += 1f;
		}
		else if (A_0 >= HorizontalDirection.Southwest)
		{
			result.X -= 1f;
		}
		return result;
	}

	// Token: 0x0600110A RID: 4362 RVA: 0x00046670 File Offset: 0x00044870
	public static HorizontalDirection a()
	{
		return (HorizontalDirection)bnx.a.Next(8);
	}

	// Token: 0x0600110B RID: 4363 RVA: 0x00046680 File Offset: 0x00044880
	public static string a(HorizontalDirection A_0)
	{
		switch (A_0)
		{
		case HorizontalDirection.North:
			return "N";
		case HorizontalDirection.Northeast:
			return "NE";
		case HorizontalDirection.East:
			return "E";
		case HorizontalDirection.Southeast:
			return "SE";
		case HorizontalDirection.South:
			return "S";
		case HorizontalDirection.Southwest:
			return "SW";
		case HorizontalDirection.West:
			return "W";
		case HorizontalDirection.Northwest:
			return "NW";
		default:
			return "?";
		}
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x000466F0 File Offset: 0x000448F0
	public static HorizontalDirection a(string A_0)
	{
		string text = A_0.ToUpper();
		if (text != null)
		{
			int length = text.Length;
			if (length != 1)
			{
				if (length == 2)
				{
					char c = text[0];
					if (c != 'N')
					{
						if (c == 'S')
						{
							if (text == "SE")
							{
								return HorizontalDirection.Southeast;
							}
							if (text == "SW")
							{
								return HorizontalDirection.Southwest;
							}
						}
					}
					else
					{
						if (text == "NE")
						{
							return HorizontalDirection.Northeast;
						}
						if (text == "NW")
						{
							return HorizontalDirection.Northwest;
						}
					}
				}
			}
			else
			{
				char c = text[0];
				if (c <= 'N')
				{
					if (c == 'E')
					{
						return HorizontalDirection.East;
					}
					if (c == 'N')
					{
						return HorizontalDirection.North;
					}
				}
				else
				{
					if (c == 'S')
					{
						return HorizontalDirection.South;
					}
					if (c == 'W')
					{
						return HorizontalDirection.West;
					}
				}
			}
		}
		return HorizontalDirection.North;
	}

	// Token: 0x040009B7 RID: 2487
	private static Random a = new Random();

	// Token: 0x040009B8 RID: 2488
	public const float b = 1E-05f;

	// Token: 0x040009B9 RID: 2489
	public const int c = 4;
}
