using System;
using System.Runtime.Serialization;

// Token: 0x02001B18 RID: 6936
[eiz("IRSE")]
[Serializable]
public sealed class brt : els, ISerializable
{
	// Token: 0x06009619 RID: 38425 RVA: 0x003AC788 File Offset: 0x003AA988
	private brt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600961A RID: 38426 RVA: 0x003AC794 File Offset: 0x003AA994
	public brt() : base(brt.b, "Инфузия: рефлексы", ci8.b)
	{
		base.Icon = "Status.100";
		base.StaticEffects.Add(new bel(50));
		base.StaticEffects.Add(new a6z(50));
	}

	// Token: 0x0600961B RID: 38427 RVA: 0x003AC7E4 File Offset: 0x003AA9E4
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Infusion_Reflexes", new object[]
		{
			50
		});
	}

	// Token: 0x040039C2 RID: 14786
	private new const int a = 50;

	// Token: 0x040039C3 RID: 14787
	public static string b = "infusion_reflexes";
}
