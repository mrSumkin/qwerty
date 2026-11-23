using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E37 RID: 7735
[a1("Melee")]
[eiz("MAS")]
[Serializable]
public sealed class jk : cxd, ISerializable
{
	// Token: 0x0600AB72 RID: 43890 RVA: 0x003F69A0 File Offset: 0x003F4BA0
	private jk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AB73 RID: 43891 RVA: 0x003F69AC File Offset: 0x003F4BAC
	public override string fh()
	{
		return "Melee";
	}

	// Token: 0x0600AB74 RID: 43892 RVA: 0x003F69B4 File Offset: 0x003F4BB4
	public jk(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AB75 RID: 43893 RVA: 0x003F69C0 File Offset: 0x003F4BC0
	protected override Dictionary<Type, float> fi()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(d3m),
				1f
			},
			{
				typeof(cwu),
				1f
			}
		};
	}
}
