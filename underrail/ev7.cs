using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001AA RID: 426
public static class ev7
{
	// Token: 0x06000C34 RID: 3124 RVA: 0x00031ECC File Offset: 0x000300CC
	public static List<string> a(string A_0, SpriteFont A_1, int A_2, int A_3)
	{
		string text = A_0;
		int num = A_3;
		List<string> list = new List<string>();
		if (A_0 == string.Empty)
		{
			list.Add(string.Empty);
		}
		else
		{
			while (!string.IsNullOrEmpty(text))
			{
				int num2 = -1;
				for (int i = 0; i < text.Length; i++)
				{
					if ((int)A_1.MeasureString(text.Substring(0, i + 1)).X > num)
					{
						string text2;
						string text3;
						if (num2 > 0)
						{
							text2 = text.Substring(0, num2);
							text3 = text.Substring(num2 + 1);
						}
						else if (A_3 < A_2 && num == A_3)
						{
							text2 = "";
							text3 = text;
						}
						else
						{
							if (i <= 0)
							{
								return list;
							}
							text2 = text.Substring(0, i);
							text3 = text.Substring(i);
						}
						list.Add(text2.TrimEnd(new char[]
						{
							' '
						}));
						text = text3.TrimStart(new char[]
						{
							' '
						});
						num = A_2;
						break;
					}
					if (text[i] == ' ')
					{
						num2 = i;
					}
					if (i == text.Length - 1)
					{
						list.Add(text);
						text = string.Empty;
						break;
					}
				}
			}
		}
		return list;
	}
}
