using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001170 RID: 4464
public sealed class zx
{
	// Token: 0x06005F7F RID: 24447 RVA: 0x00298068 File Offset: 0x00296268
	public void a(cde A_0, CharacterState A_1, string A_2)
	{
		this.a[A_1] = new am5(A_2 + bz9.a[A_1], A_0.a(A_1), A_0.b(A_1));
	}

	// Token: 0x06005F80 RID: 24448 RVA: 0x002980A8 File Offset: 0x002962A8
	public void a(cde A_0, CharacterState A_1, string A_2, string A_3, string A_4, bool A_5)
	{
		this.a[A_1] = new am5(A_2 + bz9.a[A_1] + A_3, A_5 ? A_0.a(bz9.a(A_1, A_4)) : A_0.a(A_1), A_0.b(A_1));
	}

	// Token: 0x040027E0 RID: 10208
	public Dictionary<CharacterState, am5> a = new Dictionary<CharacterState, am5>();

	// Token: 0x040027E1 RID: 10209
	public string b;

	// Token: 0x040027E2 RID: 10210
	public Point c;

	// Token: 0x040027E3 RID: 10211
	public Point d;

	// Token: 0x040027E4 RID: 10212
	public Point e;

	// Token: 0x040027E5 RID: 10213
	public int f;

	// Token: 0x040027E6 RID: 10214
	public float? g;

	// Token: 0x040027E7 RID: 10215
	public string h;
}
