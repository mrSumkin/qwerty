using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001AAA RID: 6826
[eiz("MCSSE")]
[Serializable]
public sealed class bc7 : els, ISerializable
{
	// Token: 0x06009413 RID: 37907 RVA: 0x003A4FDC File Offset: 0x003A31DC
	private bc7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("MCSSE:S", typeof(Dictionary<SkillEnum, bnw.a>)) as Dictionary<SkillEnum, bnw.a>);
	}

	// Token: 0x06009414 RID: 37908 RVA: 0x003A5008 File Offset: 0x003A3208
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MCSSE:S", this.a);
	}

	// Token: 0x06009415 RID: 37909 RVA: 0x003A5028 File Offset: 0x003A3228
	public bc7(int A_0) : base(bc7.b, "Моторно-когнитивный приёмник", ci8.b)
	{
		this.a = new Dictionary<SkillEnum, bnw.a>();
		foreach (object obj in Enum.GetValues(typeof(SkillEnum)))
		{
			SkillEnum skillEnum = (SkillEnum)obj;
			if (skillEnum < SkillEnum.Dodge)
			{
				this.a[skillEnum] = new bnw.a(skillEnum.a());
			}
		}
		base.Duration = A_0;
		base.TickPeriod = d0u.b;
		base.Icon = "Psi.MotorCognitiveReceiver";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
	}

	// Token: 0x06009416 RID: 37910 RVA: 0x003A50F8 File Offset: 0x003A32F8
	public override string cb(ll A_0)
	{
		string text = "";
		if (A_0 != null && A_0.a() != null)
		{
			Dictionary<csn, int> dictionary = ech.a(A_0.a(), this, null);
			bool flag = false;
			foreach (KeyValuePair<csn, int> keyValuePair in dictionary)
			{
				csn key = keyValuePair.Key;
				if (key != null)
				{
					int num = keyValuePair.Value - key.f();
					if (num > 0)
					{
						if (!flag)
						{
							text += string.Format("Эффективное значение базового навыка {0} увеличено на {1}.", key.Name.ToLowerInvariant(), num);
							flag = true;
						}
						else
						{
							text += string.Format(", {0} на {1}", key.Name.ToLowerInvariant(), num);
						}
					}
				}
			}
			if (flag)
			{
				text += ".";
			}
		}
		return text;
	}

	// Token: 0x040038E7 RID: 14567
	public new Dictionary<SkillEnum, bnw.a> a;

	// Token: 0x040038E8 RID: 14568
	public static readonly string b = "motorCognitiveReceiver";
}
