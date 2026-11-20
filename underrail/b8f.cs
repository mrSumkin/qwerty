using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001C3D RID: 7229
[d29("TattooTchortInstitute", "Tattoo: The Institute of Tchort")]
public sealed class b8f : e33
{
	// Token: 0x06009EB7 RID: 40631 RVA: 0x003E2838 File Offset: 0x003E0A38
	public b8f() : base("Татуировка: Институт Чорта")
	{
	}

	// Token: 0x06009EB8 RID: 40632 RVA: 0x003E2848 File Offset: 0x003E0A48
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new dpw(SkillEnum.Biology.ToString(), b8f.a),
			new dpw(SkillEnum.Chemistry.ToString(), b8f.a)
		};
	}

	// Token: 0x06009EB9 RID: 40633 RVA: 0x003E289C File Offset: 0x003E0A9C
	public override object[] at()
	{
		return new object[]
		{
			b8f.a
		};
	}

	// Token: 0x04003D7E RID: 15742
	public new static readonly int a = 7;
}
