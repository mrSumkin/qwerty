using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001126 RID: 4390
[eiz("PCJ")]
[Serializable]
public sealed class dgq : cze, ISerializable
{
	// Token: 0x06005DD7 RID: 24023 RVA: 0x0027CFCC File Offset: 0x0027B1CC
	private dgq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("PCJ:CWP");
			return;
		}
		if (base.GetType() == typeof(dgq))
		{
			this.a = A_0.GetString("_CutsceneWorkflowPath");
			return;
		}
		this.a = A_0.GetString("PlayCutsceneJob+_CutsceneWorkflowPath");
	}

	// Token: 0x06005DD8 RID: 24024 RVA: 0x0027D03C File Offset: 0x0027B23C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PCJ:CWP", this.a);
	}

	// Token: 0x06005DD9 RID: 24025 RVA: 0x0027D058 File Offset: 0x0027B258
	public string a()
	{
		return this.a;
	}

	// Token: 0x06005DDA RID: 24026 RVA: 0x0027D060 File Offset: 0x0027B260
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005DDB RID: 24027 RVA: 0x0027D06C File Offset: 0x0027B26C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		bpo.GetServiceOrThrow<ps>().am3(this.a);
	}

	// Token: 0x06005DDC RID: 24028 RVA: 0x0027D080 File Offset: 0x0027B280
	public dgq()
	{
	}

	// Token: 0x04002559 RID: 9561
	private new string a;
}
