using System;
using System.Runtime.Serialization;

// Token: 0x020019A7 RID: 6567
[eiz("ACX1")]
[dn2("SpewAcid")]
[Serializable]
public sealed class dqi : buu, ISerializable
{
	// Token: 0x06008C31 RID: 35889 RVA: 0x00390DFC File Offset: 0x0038EFFC
	private dqi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008C32 RID: 35890 RVA: 0x00390E08 File Offset: 0x0038F008
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% разбрызгать кислоту.", (int)(A_0.Chance * 100.0));
		}
		return "Разбрызгивает кислоту.";
	}

	// Token: 0x06008C33 RID: 35891 RVA: 0x00390E44 File Offset: 0x0038F044
	public dqi()
	{
	}
}
