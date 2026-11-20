using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001AAC RID: 6828
[eiz("MCSSE2")]
[Serializable]
public sealed class a1u : els, ISerializable
{
	// Token: 0x0600941D RID: 37917 RVA: 0x003A52F4 File Offset: 0x003A34F4
	private a1u(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("MCSSE2:S", typeof(Dictionary<SkillEnum, int>)) as Dictionary<SkillEnum, int>);
	}

	// Token: 0x0600941E RID: 37918 RVA: 0x003A5320 File Offset: 0x003A3520
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MCSSE2:S", this.b);
	}

	// Token: 0x0600941F RID: 37919 RVA: 0x003A5340 File Offset: 0x003A3540
	public a1u(int A_0, Dictionary<SkillEnum, int> A_1 = null) : base(a1u.a, "Моторно-когнитивный источник", ci8.c)
	{
		base.Duration = A_0;
		base.TickPeriod = d0u.b;
		base.Icon = "Psi.MotorCognitiveSource";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		if (A_1 != null)
		{
			this.b = new Dictionary<SkillEnum, int>(A_1);
			return;
		}
		this.b = new Dictionary<SkillEnum, int>();
	}

	// Token: 0x06009420 RID: 37920 RVA: 0x003A53A8 File Offset: 0x003A35A8
	public override string cb(ll A_0)
	{
		string text = "";
		bool flag = false;
		foreach (KeyValuePair<SkillEnum, int> keyValuePair in this.b)
		{
			if (keyValuePair.Value > 0)
			{
				string arg = keyValuePair.Key.a().ToLowerInvariant();
				if (!flag)
				{
					flag = true;
					text += string.Format("Эффективное значение базового навыка {0} уменьшено на {1}.", arg, keyValuePair.Value);
				}
				else
				{
					text += string.Format(", {0} на {1}", arg, keyValuePair.Value);
				}
			}
		}
		if (flag)
		{
			text += ".";
		}
		return text;
	}

	// Token: 0x06009421 RID: 37921 RVA: 0x003A5488 File Offset: 0x003A3688
	public void a(SkillEnum A_0, int A_1)
	{
		if (A_1 > 0)
		{
			int num;
			if (this.b.TryGetValue(A_0, out num))
			{
				this.b[A_0] = num + A_1;
				return;
			}
			this.b[A_0] = A_1;
		}
	}

	// Token: 0x040038EB RID: 14571
	public new static readonly string a = "motorCognitiveSource";

	// Token: 0x040038EC RID: 14572
	public Dictionary<SkillEnum, int> b;
}
