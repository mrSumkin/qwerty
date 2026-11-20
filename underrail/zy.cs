using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Xna.Framework;

// Token: 0x0200009E RID: 158
public static class zy
{
	// Token: 0x060003A4 RID: 932 RVA: 0x000114E4 File Offset: 0x0000F6E4
	public static Color e(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return Color.Black;
		}
		string[] array = A_0.Split(new char[]
		{
			','
		});
		if (array.Length >= 3)
		{
			byte r;
			if (!byte.TryParse(array[0], NumberStyles.Number, CultureInfo.InvariantCulture, out r))
			{
				r = 0;
			}
			byte g;
			if (!byte.TryParse(array[1], NumberStyles.Number, CultureInfo.InvariantCulture, out g))
			{
				g = 0;
			}
			byte b;
			if (!byte.TryParse(array[2], NumberStyles.Number, CultureInfo.InvariantCulture, out b))
			{
				b = 0;
			}
			byte a;
			if (array.Length >= 4)
			{
				if (!byte.TryParse(array[3], NumberStyles.Number, CultureInfo.InvariantCulture, out a))
				{
					a = 0;
				}
			}
			else
			{
				a = byte.MaxValue;
			}
			return new Color((int)r, (int)g, (int)b, (int)a);
		}
		return Color.Transparent;
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x000115B8 File Offset: 0x0000F7B8
	public static Color? d(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return null;
		}
		string[] array = A_0.Split(new char[]
		{
			','
		});
		if (array.Length < 3)
		{
			return null;
		}
		byte r;
		if (!byte.TryParse(array[0], NumberStyles.Number, CultureInfo.InvariantCulture, out r))
		{
			return null;
		}
		byte g;
		if (!byte.TryParse(array[1], NumberStyles.Number, CultureInfo.InvariantCulture, out g))
		{
			return null;
		}
		byte b;
		if (!byte.TryParse(array[2], NumberStyles.Number, CultureInfo.InvariantCulture, out b))
		{
			return null;
		}
		byte maxValue;
		if (array.Length >= 4)
		{
			if (!byte.TryParse(array[3], NumberStyles.Number, CultureInfo.InvariantCulture, out maxValue))
			{
				return null;
			}
		}
		else
		{
			maxValue = byte.MaxValue;
		}
		return new Color?(new Color((int)r, (int)g, (int)b, (int)maxValue));
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x000116B0 File Offset: 0x0000F8B0
	public static string a(Vector3 A_0)
	{
		return string.Format("{0}, {1}, {2}", A_0.X, A_0.Y, A_0.Z);
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x000116E0 File Offset: 0x0000F8E0
	public static Vector3 c(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return Vector3.Zero;
		}
		string[] array = A_0.Split(new char[]
		{
			','
		});
		if (array.Length >= 3)
		{
			float x;
			if (!float.TryParse(array[0], NumberStyles.Float, CultureInfo.InvariantCulture, out x))
			{
				x = 0f;
			}
			float y;
			if (!float.TryParse(array[1], NumberStyles.Float, CultureInfo.InvariantCulture, out y))
			{
				y = 0f;
			}
			float z;
			if (!float.TryParse(array[2], NumberStyles.Float, CultureInfo.InvariantCulture, out z))
			{
				z = 0f;
			}
			return new Vector3(x, y, z);
		}
		return Vector3.Zero;
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x00011798 File Offset: 0x0000F998
	public static Point b(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return Point.Zero;
		}
		string[] array = A_0.Split(new char[]
		{
			','
		});
		if (array.Length >= 2)
		{
			int x;
			if (!int.TryParse(array[0], NumberStyles.Number, CultureInfo.InvariantCulture, out x))
			{
				x = 0;
			}
			int y;
			if (!int.TryParse(array[1], NumberStyles.Number, CultureInfo.InvariantCulture, out y))
			{
				y = 0;
			}
			return new Point(x, y);
		}
		return Point.Zero;
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x0001181C File Offset: 0x0000FA1C
	public static List<KeyValuePair<string[], string>> a(string A_0)
	{
		List<KeyValuePair<string[], string>> list = new List<KeyValuePair<string[], string>>();
		if (!string.IsNullOrEmpty(A_0))
		{
			List<string> list2 = new List<string>();
			string text = A_0;
			while (!string.IsNullOrEmpty(text))
			{
				int num = text.IndexOf("[/");
				int num2 = text.IndexOf('[');
				if (num2 != -1 && (num == -1 || num2 < num))
				{
					int num3 = text.IndexOf(']', num2 + 1);
					if (num3 != -1)
					{
						if (num2 != 0)
						{
							list.Add(new KeyValuePair<string[], string>(list2.ToArray(), text.Substring(0, num2)));
						}
						if (num3 > num2 + 1)
						{
							string text2 = text.Substring(num2 + 1, num3 - num2 - 1);
							if (!string.IsNullOrWhiteSpace(text2))
							{
								list2.Add(text2.Trim());
							}
						}
						text = text.Substring(num3 + 1);
					}
					else
					{
						list.Add(new KeyValuePair<string[], string>(list2.ToArray(), text));
						text = null;
					}
				}
				else if (num != -1)
				{
					int num4 = text.IndexOf(']', num + 1);
					if (num4 != -1)
					{
						if (num != 0)
						{
							list.Add(new KeyValuePair<string[], string>(list2.ToArray(), text.Substring(0, num2)));
						}
						if (num4 > num + 1)
						{
							string text3 = text.Substring(num2 + 2, num4 - num - 2);
							if (!string.IsNullOrWhiteSpace(text3))
							{
								list2.Remove(text3.Trim());
							}
						}
						text = text.Substring(num4 + 1);
					}
					else
					{
						list.Add(new KeyValuePair<string[], string>(list2.ToArray(), text));
						text = null;
					}
				}
				else
				{
					list.Add(new KeyValuePair<string[], string>(list2.ToArray(), text));
					text = null;
				}
			}
		}
		return list;
	}
}
