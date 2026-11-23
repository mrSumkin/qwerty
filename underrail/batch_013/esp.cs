using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020007AF RID: 1967
[eiz("WBA1GM")]
[e79("WBA1GM")]
[Serializable]
public sealed class esp : eps, ISerializable
{
	// Token: 0x06003155 RID: 12629 RVA: 0x0012ECA0 File Offset: 0x0012CEA0
	private esp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003156 RID: 12630 RVA: 0x0012ECAC File Offset: 0x0012CEAC
	public esp()
	{
		s5 s = new s5();
		s.e().b(bat.a);
		s.a(new bt4("guardPos1b"));
		s.a(true);
		bb8 bb = new bb8();
		bb.h().b(bat.a);
		bb.a(CharacterState.OperateShort);
		a5 a = new a5();
		a.a(new ar7(new Guid("cc82b5e1-06fa-48d3-b550-76b1379cbc60"), new Guid("49f3a4aa-8082-49a2-a67a-13cc9f3d8586"), new Guid("f0c9aef1-4643-41d7-99c6-bccbee99f80c"), bl1.a));
		a5 a2 = new a5();
		a2.a(new ar7(new Guid("cdcc66a4-f5a0-4349-93ee-9bcf05ae3204"), new Guid("49f3a4aa-8082-49a2-a67a-13cc9f3d8586"), new Guid("f0c9aef1-4643-41d7-99c6-bccbee99f80c"), bl1.a));
		s5 s2 = new s5();
		s2.e().b(bat.a);
		s2.a(new bt4("guardPos2"));
		s2.a(true);
		cw8 cw = new cw8();
		cw.a(TimeSpan.FromMilliseconds(300.0));
		base.a(new btm[]
		{
			s,
			cw,
			bb,
			a,
			a2,
			cw,
			s2
		});
	}
}
