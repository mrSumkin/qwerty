using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200138D RID: 5005
[bs6("HFX:PlayerMutantFireHand")]
[eiz("PMFHHE2A")]
[Serializable]
public sealed class bla : cpl, ISerializable
{
	// Token: 0x06007133 RID: 28979 RVA: 0x002F8634 File Offset: 0x002F6834
	private bla(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007134 RID: 28980 RVA: 0x002F8640 File Offset: 0x002F6840
	public bla()
	{
	}

	// Token: 0x06007135 RID: 28981 RVA: 0x002F864C File Offset: 0x002F684C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.a() != null && base.a().aa() != null && !base.a().aa().Dead)
		{
			b4p b4p = Enumerable.FirstOrDefault<b4p>(base.a().aa().StatusEffects.Get<b4p>());
			if (b4p != null)
			{
				b4p b4p2 = b4p;
				int num = b4p2.Stacks - 1;
				b4p2.Stacks = num;
				if (num <= 0)
				{
					base.a().aa().StatusEffects.d(b4p);
				}
			}
		}
		return dc4.c;
	}
}
