using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework.Input;

// Token: 0x020005E8 RID: 1512
[eiz("SPC")]
[Serializable]
public sealed class c1r : dth, ISerializable
{
	// Token: 0x060027B4 RID: 10164 RVA: 0x000E6A88 File Offset: 0x000E4C88
	private c1r(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060027B5 RID: 10165 RVA: 0x000E6A90 File Offset: 0x000E4C90
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060027B6 RID: 10166 RVA: 0x000E6A94 File Offset: 0x000E4C94
	public c1r()
	{
	}

	// Token: 0x060027B7 RID: 10167 RVA: 0x000E6AA0 File Offset: 0x000E4CA0
	public bool jh(object A_0)
	{
		return Keyboard.GetState().IsKeyDown(Keys.LeftAlt);
	}

	// Token: 0x060027B8 RID: 10168 RVA: 0x000E6AC0 File Offset: 0x000E4CC0
	public string ji()
	{
		return null;
	}
}
