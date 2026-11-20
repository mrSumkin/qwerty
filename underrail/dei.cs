using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E36 RID: 7734
[eiz("GS1")]
[a1("Throwing")]
[Serializable]
public sealed class dei : cxd, ISerializable
{
	// Token: 0x0600AB6E RID: 43886 RVA: 0x003F6964 File Offset: 0x003F4B64
	private dei(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AB6F RID: 43887 RVA: 0x003F6970 File Offset: 0x003F4B70
	public override string fh()
	{
		return "Throwing";
	}

	// Token: 0x0600AB70 RID: 43888 RVA: 0x003F6978 File Offset: 0x003F4B78
	public dei(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AB71 RID: 43889 RVA: 0x003F6984 File Offset: 0x003F4B84
	protected override Dictionary<Type, float> fi()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(cwu),
				1f
			}
		};
	}
}
