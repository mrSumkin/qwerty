using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200111F RID: 4383
[eiz("ASWJ")]
[Serializable]
public sealed class iz : cze, ISerializable
{
	// Token: 0x06005D90 RID: 23952 RVA: 0x0027BE14 File Offset: 0x0027A014
	private iz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("ASWJ:WP");
			this.b = A_0.GetBoolean("ASWJ:QSAA");
			return;
		}
		if (base.GetType() == typeof(iz))
		{
			this.a = A_0.GetString("_WorkflowPath");
			this.b = A_0.GetBoolean("_QueueStartAfterAttaching");
			return;
		}
		this.a = A_0.GetString("AttachSoloWorkflowJob+_WorkflowPath");
		this.b = A_0.GetBoolean("AttachSoloWorkflowJob+_QueueStartAfterAttaching");
	}

	// Token: 0x06005D91 RID: 23953 RVA: 0x0027BEB8 File Offset: 0x0027A0B8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ASWJ:WP", this.a);
		info.AddValue("ASWJ:QSAA", this.b);
	}

	// Token: 0x06005D92 RID: 23954 RVA: 0x0027BEE4 File Offset: 0x0027A0E4
	public string b()
	{
		return this.a;
	}

	// Token: 0x06005D93 RID: 23955 RVA: 0x0027BEEC File Offset: 0x0027A0EC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005D94 RID: 23956 RVA: 0x0027BEF8 File Offset: 0x0027A0F8
	public bool a()
	{
		return this.b;
	}

	// Token: 0x06005D95 RID: 23957 RVA: 0x0027BF00 File Offset: 0x0027A100
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005D96 RID: 23958 RVA: 0x0027BF0C File Offset: 0x0027A10C
	public iz()
	{
	}

	// Token: 0x06005D97 RID: 23959 RVA: 0x0027BF18 File Offset: 0x0027A118
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && !string.IsNullOrWhiteSpace(this.a))
		{
			bm6 aspect = A_1.GetAspect<bm6>();
			if (aspect != null)
			{
				ai ai = bpo.GetServiceOrThrow<bjk>().ac5(this.a);
				if (ai != null)
				{
					aspect.a(ai);
					if (this.b)
					{
						aspect.aj();
					}
				}
			}
		}
	}

	// Token: 0x04002544 RID: 9540
	private new string a;

	// Token: 0x04002545 RID: 9541
	private bool b;
}
