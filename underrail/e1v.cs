using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200053E RID: 1342
[eiz("CHE")]
[Serializable]
public sealed class e1v : aeq, b2h, ISerializable
{
	// Token: 0x06002255 RID: 8789 RVA: 0x000B59CC File Offset: 0x000B3BCC
	private e1v(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ap9)A_0.GetValue("CHE:H", typeof(ap9));
			this.b = A_0.GetValue("CHE:P", typeof(object));
			this.c = A_0.GetInt32("CHE:A");
			if (ell.a() >= 631)
			{
				this.d = A_0.GetBoolean("CHE:C");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(e1v))
			{
				this.a = (ap9)A_0.GetValue("_Healer", typeof(ap9));
				this.b = A_0.GetValue("_Proxy", typeof(object));
				this.c = A_0.GetInt32("_Amount");
				return;
			}
			this.a = (ap9)A_0.GetValue("CharacterHealedEvent+_Healer", typeof(ap9));
			this.b = A_0.GetValue("CharacterHealedEvent+_Proxy", typeof(object));
			this.c = A_0.GetInt32("CharacterHealedEvent+_Amount");
		}
	}

	// Token: 0x06002256 RID: 8790 RVA: 0x000B5B0C File Offset: 0x000B3D0C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CHE:H", this.a);
		info.AddValue("CHE:P", this.b);
		info.AddValue("CHE:A", this.c);
		info.AddValue("CHE:C", this.d);
	}

	// Token: 0x06002257 RID: 8791 RVA: 0x000B5B68 File Offset: 0x000B3D68
	public e1v(ap9 A_0, ap9 A_1, object A_2, int A_3, bool A_4) : base(A_0)
	{
		this.a = A_1;
		this.b = A_2;
		this.c = A_3;
		this.d = A_4;
	}

	// Token: 0x06002258 RID: 8792 RVA: 0x000B5B90 File Offset: 0x000B3D90
	public bool a()
	{
		return false;
	}

	// Token: 0x06002259 RID: 8793 RVA: 0x000B5B94 File Offset: 0x000B3D94
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x0600225A RID: 8794 RVA: 0x000B5BD0 File Offset: 0x000B3DD0
	public ecs se()
	{
		if (base.h() != null && !string.IsNullOrEmpty(base.h().a))
		{
			string text;
			if (this.d)
			{
				text = "с критическим эффектом ";
			}
			else
			{
				text = "";
			}
			string str;
			if (this.a != null && !string.IsNullOrEmpty(this.a.a))
			{
				if (this.a.d == base.h().d)
				{
					Gender f = base.h().f;
					string text2;
					if (f != Gender.Male)
					{
						if (f != Gender.Female)
						{
							text2 = "себя";
						}
						else
						{
							text2 = "себя";
						}
					}
					else
					{
						text2 = "себя";
					}
					if (this.b != null)
					{
						str = string.Concat(new string[]
						{
							"{0} ",
							text,
							"лечит ",
							text2,
							", используя {2}"
						});
					}
					else
					{
						str = "{0} " + text + "лечит " + text2;
					}
				}
				else if (this.b != null)
				{
					str = "{0} {2} " + text + "лечит {1}";
				}
				else
				{
					str = "{0} " + text + "лечит {1}";
				}
			}
			else if (this.b != null)
			{
				str = "{2} " + text + "лечит {1}";
			}
			else
			{
				str = "{1} " + text + "исцеляется";
			}
			ecs ecs = new ecs();
			dl6 dl = new dl6();
			dl.a.Add(new bph(bvm.a(), string.Format("- " + str + " на ", this.a, base.h(), this.b), null));
			dl.a.Add(new bph(bvm.a(adi.w), this.c.ToString(), null));
			dl.a.Add(new bph(bvm.a(), " очков здоровья.", null));
			ecs.a.Add(dl);
			return ecs;
		}
		return null;
	}

	// Token: 0x04001475 RID: 5237
	private ap9 a;

	// Token: 0x04001476 RID: 5238
	private object b;

	// Token: 0x04001477 RID: 5239
	private int c;

	// Token: 0x04001478 RID: 5240
	private bool d;
}
