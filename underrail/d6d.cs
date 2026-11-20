using System;
using System.Runtime.Serialization;

// Token: 0x02001172 RID: 4466
[eiz("S14")]
[Serializable]
public sealed class d6d : ISerializable
{
	// Token: 0x06005F84 RID: 24452 RVA: 0x00298140 File Offset: 0x00296340
	private d6d(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt32("S14:L");
		this.b = A_0.GetInt32("S14:S");
	}

	// Token: 0x06005F85 RID: 24453 RVA: 0x0029816C File Offset: 0x0029636C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("S14:L", this.a);
		info.AddValue("S14:S", this.b);
	}

	// Token: 0x170001CF RID: 463
	// (get) Token: 0x06005F86 RID: 24454 RVA: 0x00298190 File Offset: 0x00296390
	// (set) Token: 0x06005F87 RID: 24455 RVA: 0x00298198 File Offset: 0x00296398
	public int TargetLevel
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x170001D0 RID: 464
	// (get) Token: 0x06005F88 RID: 24456 RVA: 0x002981A4 File Offset: 0x002963A4
	// (set) Token: 0x06005F89 RID: 24457 RVA: 0x002981AC File Offset: 0x002963AC
	public int RequiredSkill
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x06005F8A RID: 24458 RVA: 0x002981B8 File Offset: 0x002963B8
	public d6d()
	{
	}

	// Token: 0x06005F8B RID: 24459 RVA: 0x002981C0 File Offset: 0x002963C0
	public d6d(int A_0, int A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x040027EB RID: 10219
	private int a;

	// Token: 0x040027EC RID: 10220
	private int b;
}
