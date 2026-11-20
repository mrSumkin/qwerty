using System;
using System.Collections.Generic;
using System.Linq;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020003CE RID: 974
[fe("devourer")]
public sealed class gz : am2
{
	// Token: 0x06001A49 RID: 6729 RVA: 0x0008DC8C File Offset: 0x0008BE8C
	public gz(bm6 A_0) : base(A_0)
	{
		e1y e1y = Enumerable.FirstOrDefault<e1y>(Enumerable.OfType<e1y>(base.g()));
		if (e1y != null)
		{
			e1y.b = false;
			e1y.g().Clear();
			e1y.a(new List<c96>
			{
				new c1j("Howl")
				{
					c = 1f,
					b = "DevourerRoar",
					d = new CharacterState?(CharacterState.Custom1)
				},
				new e7y("IdleMoveToTile")
				{
					c = 0.75f,
					b = 5,
					c = 3
				},
				new aif("RestActivity")
			});
		}
	}
}
