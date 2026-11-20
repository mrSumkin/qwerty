using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

// Token: 0x020001A7 RID: 423
public static class b5u
{
	// Token: 0x06000C29 RID: 3113 RVA: 0x00030B50 File Offset: 0x0002ED50
	static b5u()
	{
		for (int i = 65; i <= 90; i++)
		{
			string text = new string((char)i, 1).ToLowerInvariant();
			string text2 = new string((char)i, 1).ToUpperInvariant();
			b5u.a.Add((Keys)i, new char[]
			{
				text[0],
				text2[0]
			});
		}
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x00030F70 File Offset: 0x0002F170
	public static char a(Keys A_0, bool A_1, bool A_2 = true)
	{
		if (b5u.b != null && A_2)
		{
			char c = b5u.b(A_0, A_1);
			if (c != '\0')
			{
				return c;
			}
		}
		char[] array;
		b5u.a.TryGetValue(A_0, out array);
		char result = '\0';
		if (array != null)
		{
			result = array[(A_1 > false) ? 1 : 0];
		}
		return result;
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x00030FC0 File Offset: 0x0002F1C0
	public static awt a()
	{
		awt result = default(awt);
		KeyboardState state = Keyboard.GetState();
		result.a = state.IsKeyDown(Keys.LeftShift);
		result.b = state.IsKeyDown(Keys.RightShift);
		result.c = state.IsKeyDown(Keys.LeftControl);
		result.d = state.IsKeyDown(Keys.RightControl);
		result.e = state.IsKeyDown(Keys.LeftAlt);
		result.f = state.IsKeyDown(Keys.RightAlt);
		return result;
	}

	// Token: 0x0400073B RID: 1851
	private static Dictionary<Keys, char[]> a = new Dictionary<Keys, char[]>
	{
		{
			Keys.Space,
			new char[]
			{
				' ',
				' '
			}
		},
		{
			Keys.NumPad0,
			new char[]
			{
				'0',
				'0'
			}
		},
		{
			Keys.NumPad1,
			new char[]
			{
				'1',
				'1'
			}
		},
		{
			Keys.NumPad2,
			new char[]
			{
				'2',
				'2'
			}
		},
		{
			Keys.NumPad3,
			new char[]
			{
				'3',
				'3'
			}
		},
		{
			Keys.NumPad4,
			new char[]
			{
				'4',
				'4'
			}
		},
		{
			Keys.NumPad5,
			new char[]
			{
				'5',
				'5'
			}
		},
		{
			Keys.NumPad6,
			new char[]
			{
				'6',
				'6'
			}
		},
		{
			Keys.NumPad7,
			new char[]
			{
				'7',
				'7'
			}
		},
		{
			Keys.NumPad8,
			new char[]
			{
				'8',
				'8'
			}
		},
		{
			Keys.NumPad9,
			new char[]
			{
				'9',
				'9'
			}
		},
		{
			Keys.Multiply,
			new char[]
			{
				'*',
				'*'
			}
		},
		{
			Keys.Add,
			new char[]
			{
				'+',
				'+'
			}
		},
		{
			Keys.Subtract,
			new char[]
			{
				'-',
				'-'
			}
		},
		{
			Keys.Divide,
			new char[]
			{
				'/',
				'/'
			}
		},
		{
			Keys.Decimal,
			new char[]
			{
				'.',
				'.'
			}
		},
		{
			Keys.OemSemicolon,
			new char[]
			{
				';',
				':'
			}
		},
		{
			Keys.OemPlus,
			new char[]
			{
				'=',
				'+'
			}
		},
		{
			Keys.OemComma,
			new char[]
			{
				',',
				'<'
			}
		},
		{
			Keys.OemMinus,
			new char[]
			{
				'-',
				'_'
			}
		},
		{
			Keys.OemPeriod,
			new char[]
			{
				'.',
				'>'
			}
		},
		{
			Keys.OemQuestion,
			new char[]
			{
				'/',
				'?'
			}
		},
		{
			Keys.OemQuotes,
			new char[]
			{
				'\'',
				'"'
			}
		},
		{
			Keys.OemTilde,
			new char[]
			{
				'`',
				'~'
			}
		},
		{
			Keys.OemOpenBrackets,
			new char[]
			{
				'[',
				'{'
			}
		},
		{
			Keys.OemCloseBrackets,
			new char[]
			{
				']',
				'}'
			}
		},
		{
			Keys.OemPipe,
			new char[]
			{
				'\\',
				'|'
			}
		},
		{
			Keys.OemBackslash,
			new char[]
			{
				'\\',
				'|'
			}
		},
		{
			Keys.D0,
			new char[]
			{
				'0',
				')'
			}
		},
		{
			Keys.D1,
			new char[]
			{
				'1',
				'!'
			}
		},
		{
			Keys.D2,
			new char[]
			{
				'2',
				'@'
			}
		},
		{
			Keys.D3,
			new char[]
			{
				'3',
				'#'
			}
		},
		{
			Keys.D4,
			new char[]
			{
				'4',
				'$'
			}
		},
		{
			Keys.D5,
			new char[]
			{
				'5',
				'%'
			}
		},
		{
			Keys.D6,
			new char[]
			{
				'6',
				'^'
			}
		},
		{
			Keys.D7,
			new char[]
			{
				'7',
				'&'
			}
		},
		{
			Keys.D8,
			new char[]
			{
				'8',
				'*'
			}
		},
		{
			Keys.D9,
			new char[]
			{
				'9',
				'('
			}
		}
	};

	// Token: 0x0400073C RID: 1852
	public static Func<Keys, bool, char> b;
}
