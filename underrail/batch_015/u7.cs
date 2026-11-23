using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000AD2 RID: 2770
[eiz("XPBLQCLJ")]
[Serializable]
public sealed class u7 : cze, ISerializable
{
	// Token: 0x0600409B RID: 16539 RVA: 0x00189880 File Offset: 0x00187A80
	private u7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600409C RID: 16540 RVA: 0x0018988C File Offset: 0x00187A8C
	public u7()
	{
	}

	// Token: 0x0600409D RID: 16541 RVA: 0x00189898 File Offset: 0x00187A98
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 is c5x)
		{
			amc aspect = A_0.GetAspect<amc>();
			ny aspect2 = A_0.GetAspect<ny>();
			if (aspect != null && aspect2 != null)
			{
				e4t a_ = new e4t(aspect, CharacterState.Throw, dz6.b(70), 4, new int?(6), 1);
				aspect2.b(a_, atp.a);
			}
		}
	}
}
