using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001CF9 RID: 7417
[eiz("TMS")]
[a1("Temporal Manipulation")]
[Serializable]
public sealed class p5 : eoh, ISerializable
{
	// Token: 0x0600A303 RID: 41731 RVA: 0x003EA928 File Offset: 0x003E8B28
	private p5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600A304 RID: 41732 RVA: 0x003EA934 File Offset: 0x003E8B34
	public override string fh()
	{
		return "Temporal Manipulation";
	}

	// Token: 0x0600A305 RID: 41733 RVA: 0x003EA93C File Offset: 0x003E8B3C
	public override string j6()
	{
		return "xpbl";
	}

	// Token: 0x0600A306 RID: 41734 RVA: 0x003EA944 File Offset: 0x003E8B44
	public p5(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600A307 RID: 41735 RVA: 0x003EA950 File Offset: 0x003E8B50
	protected override Dictionary<Type, float> fi()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(axr),
				1f
			}
		};
	}

	// Token: 0x0600A308 RID: 41736 RVA: 0x003EA970 File Offset: 0x003E8B70
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(rs),
				0.1f
			},
			{
				typeof(dql),
				0.1f
			},
			{
				typeof(fd),
				0.1f
			}
		};
	}
}
