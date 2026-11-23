using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200116D RID: 4461
public sealed class cde
{
	// Token: 0x06005F78 RID: 24440 RVA: 0x00296BEC File Offset: 0x00294DEC
	public int a(CharacterState A_0)
	{
		return this.a(A_0.ToString());
	}

	// Token: 0x06005F79 RID: 24441 RVA: 0x00296C04 File Offset: 0x00294E04
	public int a(string A_0)
	{
		int result;
		if (this.a.TryGetValue(A_0, out result))
		{
			return result;
		}
		return 0;
	}

	// Token: 0x06005F7A RID: 24442 RVA: 0x00296C28 File Offset: 0x00294E28
	public float? b(CharacterState A_0)
	{
		float? result;
		this.c.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x06005F7B RID: 24443 RVA: 0x00296C48 File Offset: 0x00294E48
	public cde a()
	{
		return new cde
		{
			a = new Dictionary<string, int>(this.a),
			b = new Dictionary<CharacterState, CharacterState>(this.b),
			c = new Dictionary<CharacterState, float?>(this.c),
			d = this.d,
			e = this.e,
			f = this.f,
			g = this.g,
			h = this.h,
			i = this.i,
			j = this.j,
			k = this.k,
			l = this.l
		};
	}

	// Token: 0x040025F1 RID: 9713
	public Dictionary<string, int> a = new Dictionary<string, int>();

	// Token: 0x040025F2 RID: 9714
	public Dictionary<CharacterState, CharacterState> b = new Dictionary<CharacterState, CharacterState>();

	// Token: 0x040025F3 RID: 9715
	public Dictionary<CharacterState, float?> c = new Dictionary<CharacterState, float?>();

	// Token: 0x040025F4 RID: 9716
	public string d;

	// Token: 0x040025F5 RID: 9717
	public string e;

	// Token: 0x040025F6 RID: 9718
	public bool f;

	// Token: 0x040025F7 RID: 9719
	public bool g;

	// Token: 0x040025F8 RID: 9720
	public Point h;

	// Token: 0x040025F9 RID: 9721
	public Point i;

	// Token: 0x040025FA RID: 9722
	public Point j;

	// Token: 0x040025FB RID: 9723
	public int k;

	// Token: 0x040025FC RID: 9724
	public float? l;
}
