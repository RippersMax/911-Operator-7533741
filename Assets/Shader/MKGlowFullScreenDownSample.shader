Shader "Hidden/MKGlowFullScreenDownSample" {
Properties {
 _Color ("Color", Color) = (1.000000,1.000000,1.000000,0.000000)
 _MainTex ("", 2D) = "white" { }
}
SubShader { 
 Pass {
  ZWrite Off
  Cull Off
  GpuProgramID 50056
Program "vp" {
SubProgram "d3d9 " {
"vs_3_0
					
					//
					// Generated by Microsoft (R) HLSL Shader Compiler 6.3.9600.16384
					//
					// Parameters:
					//
					//   float4 _MainTex_TexelSize;
					//   row_major float4x4 glstate_matrix_mvp;
					//
					//
					// Registers:
					//
					//   Name               Reg   Size
					//   ------------------ ----- ----
					//   glstate_matrix_mvp c0       4
					//   _MainTex_TexelSize c4       1
					//
					
					    vs_3_0
					    def c5, 1, 0, -1, 0
					    dcl_position v0
					    dcl_texcoord v1
					    dcl_position o0
					    dcl_texcoord o1
					    dcl_texcoord1 o2
					    dcl_texcoord2 o3
					    dcl_texcoord3 o4
					    dp4 o0.x, c0, v0
					    dp4 o0.y, c1, v0
					    dp4 o0.z, c2, v0
					    dp4 o0.w, c3, v0
					    mov r0.xyz, c5
					    mad r1, c4.xyxx, r0.zzyy, r0.yyyx
					    mul r2, c5.xxyy, v1.xyxx
					    add o1, r1, r2
					    mad r1, c4.xyxx, r0.xzyy, r0.yyyx
					    add o2, r1, r2
					    mad r1, c4.xyxx, r0.xxyy, r0.yyyx
					    add o3, r1, r2
					    mad r0, c4.xyxx, r0.zxyy, r0.yyyx
					    add o4, r0, r2
					
					// approximately 14 instruction slots used"
}
SubProgram "d3d11 " {
"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[7];
						vec4 _MainTex_TexelSize;
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 glstate_matrix_mvp;
						vec4 unused_1_1[18];
					};
					in  vec4 in_POSITION0;
					in  vec2 in_TEXCOORD0;
					out vec4 vs_TEXCOORD0;
					out vec4 vs_TEXCOORD1;
					out vec4 vs_TEXCOORD2;
					out vec4 vs_TEXCOORD3;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
					    u_xlat0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + u_xlat0;
					    gl_Position = glstate_matrix_mvp[3] * in_POSITION0.wwww + u_xlat0;
					    u_xlat0.xy = (-_MainTex_TexelSize.xy);
					    u_xlat0.z = float(0.0);
					    u_xlat0.w = float(1.0);
					    u_xlat1.xy = in_TEXCOORD0.xy;
					    u_xlat1.z = float(0.0);
					    u_xlat1.w = float(0.0);
					    vs_TEXCOORD0 = u_xlat0 + u_xlat1.xyww;
					    u_xlat2.xy = _MainTex_TexelSize.xy * vec2(1.0, -1.0);
					    u_xlat2.z = float(0.0);
					    u_xlat2.w = float(1.0);
					    vs_TEXCOORD1 = u_xlat1.xyww + u_xlat2;
					    u_xlat2.y = _MainTex_TexelSize.y;
					    vs_TEXCOORD2 = u_xlat1.xyww + u_xlat2;
					    u_xlat0.y = _MainTex_TexelSize.y;
					    vs_TEXCOORD3 = u_xlat0 + u_xlat1;
					    return;
					}"
}
SubProgram "d3d11_9x " {
"vs_4_0_level_9_1
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[7];
						vec4 _MainTex_TexelSize;
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 glstate_matrix_mvp;
						vec4 unused_1_1[18];
					};
					in  vec4 in_POSITION0;
					in  vec2 in_TEXCOORD0;
					out vec4 vs_TEXCOORD0;
					out vec4 vs_TEXCOORD1;
					out vec4 vs_TEXCOORD2;
					out vec4 vs_TEXCOORD3;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
					    u_xlat0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + u_xlat0;
					    gl_Position = glstate_matrix_mvp[3] * in_POSITION0.wwww + u_xlat0;
					    u_xlat0.xy = (-_MainTex_TexelSize.xy);
					    u_xlat0.z = float(0.0);
					    u_xlat0.w = float(1.0);
					    u_xlat1.xy = in_TEXCOORD0.xy;
					    u_xlat1.z = float(0.0);
					    u_xlat1.w = float(0.0);
					    vs_TEXCOORD0 = u_xlat0 + u_xlat1.xyww;
					    u_xlat2.xy = _MainTex_TexelSize.xy * vec2(1.0, -1.0);
					    u_xlat2.z = float(0.0);
					    u_xlat2.w = float(1.0);
					    vs_TEXCOORD1 = u_xlat1.xyww + u_xlat2;
					    u_xlat2.y = _MainTex_TexelSize.y;
					    vs_TEXCOORD2 = u_xlat1.xyww + u_xlat2;
					    u_xlat0.y = _MainTex_TexelSize.y;
					    vs_TEXCOORD3 = u_xlat0 + u_xlat1;
					    return;
					}"
}
}
Program "fp" {
SubProgram "d3d9 " {
"ps_3_0
					
					//
					// Generated by Microsoft (R) HLSL Shader Compiler 6.3.9600.16384
					//
					// Parameters:
					//
					//   float4 _Color;
					//   sampler2D _MainTex;
					//
					//
					// Registers:
					//
					//   Name         Reg   Size
					//   ------------ ----- ----
					//   _Color       c0       1
					//   _MainTex     s0       1
					//
					
					    ps_3_0
					    def c1, 0.25, 0, 0, 0
					    dcl_texcoord v0.xy
					    dcl_texcoord1 v1.xy
					    dcl_texcoord2 v2.xy
					    dcl_texcoord3 v3.xy
					    dcl_2d s0
					    texld_pp r0, v0, s0
					    texld r1, v1, s0
					    add_pp r0, r0, r1
					    texld r1, v2, s0
					    add_pp r0, r0, r1
					    texld r1, v3, s0
					    add_pp r0, r0, r1
					    mul_pp r0.xyz, r0, c1.x
					    mov r1.x, c1.x
					    mad_pp r0.w, r0.w, r1.x, c0.w
					    mul_pp r0.xyz, r0, c0
					    mul_pp oC0.xyz, r0.w, r0
					    mov_pp oC0.w, c1.y
					
					// approximately 13 instruction slots used (4 texture, 9 arithmetic)"
}
SubProgram "d3d11 " {
"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[6];
						vec4 _Color;
						vec4 unused_0_2;
					};
					uniform  sampler2D _MainTex;
					in  vec4 vs_TEXCOORD0;
					in  vec4 vs_TEXCOORD1;
					in  vec4 vs_TEXCOORD2;
					in  vec4 vs_TEXCOORD3;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					float u_xlat6;
					void main()
					{
					    u_xlat0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat1 = texture(_MainTex, vs_TEXCOORD1.xy);
					    u_xlat0 = u_xlat0 + u_xlat1;
					    u_xlat1 = texture(_MainTex, vs_TEXCOORD2.xy);
					    u_xlat0 = u_xlat0 + u_xlat1;
					    u_xlat1 = texture(_MainTex, vs_TEXCOORD3.xy);
					    u_xlat0 = u_xlat0 + u_xlat1;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.25, 0.25, 0.25);
					    u_xlat6 = u_xlat0.w * 0.25 + _Color.w;
					    u_xlat0.xyz = u_xlat0.xyz * _Color.xyz;
					    SV_Target0.xyz = vec3(u_xlat6) * u_xlat0.xyz;
					    SV_Target0.w = 0.0;
					    return;
					}"
}
SubProgram "d3d11_9x " {
"ps_4_0_level_9_1
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[6];
						vec4 _Color;
						vec4 unused_0_2;
					};
					uniform  sampler2D _MainTex;
					in  vec4 vs_TEXCOORD0;
					in  vec4 vs_TEXCOORD1;
					in  vec4 vs_TEXCOORD2;
					in  vec4 vs_TEXCOORD3;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					float u_xlat6;
					void main()
					{
					    u_xlat0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat1 = texture(_MainTex, vs_TEXCOORD1.xy);
					    u_xlat0 = u_xlat0 + u_xlat1;
					    u_xlat1 = texture(_MainTex, vs_TEXCOORD2.xy);
					    u_xlat0 = u_xlat0 + u_xlat1;
					    u_xlat1 = texture(_MainTex, vs_TEXCOORD3.xy);
					    u_xlat0 = u_xlat0 + u_xlat1;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.25, 0.25, 0.25);
					    u_xlat6 = u_xlat0.w * 0.25 + _Color.w;
					    u_xlat0.xyz = u_xlat0.xyz * _Color.xyz;
					    SV_Target0.xyz = vec3(u_xlat6) * u_xlat0.xyz;
					    SV_Target0.w = 0.0;
					    return;
					}"
}
}
 }
}
Fallback Off
}